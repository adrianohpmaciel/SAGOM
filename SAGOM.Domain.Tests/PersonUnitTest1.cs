using FluentAssertions;
using SAGOM.Domain.Entities;

namespace SAGOM.Domain.Tests
{
    public class PersonUnitTest1
    {
        [Fact(DisplayName = "Create Person With Invalid CPF")]
        public void CreatePersonAsync_WithInvalidCpf_ResultDomainException()
        {            
            Action action = () => new Person("CPF INVÁLIDO AQUI", "adriano", "maciel", "rua x", "(00) 0000 0000");
            action.Should().Throw<SAGOM.Domain.Validations.DomainExceptionValidation>().WithMessage("Invalid CPF, verify the inserted value");
        }

        [Fact(DisplayName ="Create Person With Valid State")]
        public void CreatePersonAsync_WithValidParameters_ResultObjectValidState()
        {
            Action action = () => new Person("CPF AQUI", "adriano", "maciel", "rua x", "00 0000 0000");
            action.Should().NotThrow<SAGOM.Domain.Validations.DomainExceptionValidation>();
        }

        [Fact(DisplayName = "Create Person With Invalid Name")]
        public void CreatePersonAsync_WithInvalidName_ResultDomainException()
        {
            Action action = () => new Person("CPF AQUI", "adriano1", "maciel", "rua e", "00-0.0000-0000");
            action.Should().Throw<SAGOM.Domain.Validations.DomainExceptionValidation>().WithMessage("Invalid Name. Name cannot contains numbers or symbols");
        }

        [Fact(DisplayName = "Create Person With Invalid Cell Phone")]
        public void CreatePersonAsync_WithInvalidCellPhone_ResultDomainException()
        {
            Action action = () => new Person("CPF AQUI", "adriano", "maciel", "rua e", "000");
            action.Should().Throw<SAGOM.Domain.Validations.DomainExceptionValidation>().WithMessage("Invalid cellPhone, too short, minimum 10 numbers");
        }

    }
}