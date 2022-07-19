using SAGOM.Domain.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Domain.Entities
{
    public sealed class Person
    {
        public string Cpf { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string CellPhone { get; set; } = null!;

        public Person(string cpf, string name, string lastName, string address, string cellPhone)
        {
            ValidateDomain(ref cpf, ref name, ref lastName, ref address, ref cellPhone);
            Cpf = cpf;
            Name = name;
            LastName = name;
            Address = address;
            CellPhone = cellPhone;
        }

        private void ValidateDomain(ref string cpf, ref string name, ref string lastName, ref string address, ref string cellPhone)
        {
            #region CPF VALIDATION
            cpf = cpf.Trim();
            cpf = DomainAttributesValidation.GetOnlyNumbers(cpf);

            bool isInvalidCpf = string.IsNullOrEmpty(cpf);
            DomainExceptionValidation.When(isInvalidCpf, "Invalid CPF. CPF is required");

            isInvalidCpf = cpf.Length < 11;
            DomainExceptionValidation.When(isInvalidCpf, "Invalid CPF. Too short, minimum 11 numbers");

            isInvalidCpf = !ValidateCpf(ref cpf);
            DomainExceptionValidation.When(isInvalidCpf, "Invalid CPF, verify the inserted value");
            #endregion

            #region NAME VALIDATION
            name = name.Trim();

            bool isInvalidName = String.IsNullOrEmpty(name);
            DomainExceptionValidation.When(isInvalidName, "Invalid Name. Name is required");

            isInvalidName = name.Length < 3;
            DomainExceptionValidation.When(isInvalidName, "Invalid Name, too short, minimum 3 chars");

            isInvalidName = !DomainAttributesValidation.IsOnlyLetters(name);
            DomainExceptionValidation.When(isInvalidName, "Invalid Name. Name cannot contains numbers or symbols");
            #endregion

            #region LASTNAME VALIDATION
            lastName = lastName.Trim();

            bool isInvalidLastName = String.IsNullOrEmpty(lastName);
            DomainExceptionValidation.When( isInvalidLastName, "Invalid LastName. LastName is required");

            isInvalidLastName = lastName.Length < 3;
            DomainExceptionValidation.When( isInvalidLastName, "Invalid LastName, too short, minimum 3 chars");

            isInvalidLastName = !DomainAttributesValidation.IsOnlyLetters(lastName);
            DomainExceptionValidation.When( isInvalidLastName, "Invalid LastName. LastName cannot contains numbers or symbols");
            #endregion

            #region ADDRESS VALIDATION
            address = address.Trim();

            bool isInvalidAddress = String.IsNullOrEmpty(address);
            DomainExceptionValidation.When(isInvalidAddress, "Invalid address. address is required");

            isInvalidAddress = address.Length < 3;
            DomainExceptionValidation.When( isInvalidAddress, "Invalid address, too short, minimum 3 chars");
            #endregion

            #region CELL PHONE VALIDATION
            cellPhone = DomainAttributesValidation.GetOnlyNumbers(cellPhone);

            bool isInvalidCellPhone = String.IsNullOrEmpty(cellPhone);
            DomainExceptionValidation.When(isInvalidCellPhone, "Invalid cellPhone. address is required");

            isInvalidCellPhone = cellPhone.Length < 10;
            DomainExceptionValidation.When(isInvalidCellPhone, "Invalid cellPhone, too short, minimum 10 numbers");
            #endregion
        }

        private bool ValidateCpf(ref string cpf)
        {
            char[] cpfChars = cpf.ToCharArray();
            List<int> cpfNumbers = new List<int>();

            foreach (char cpfChar in cpfChars)
            {
                cpfNumbers.Add(int.Parse(cpfChar.ToString()));
            }

            int firstDigit = int.Parse(cpfNumbers[9].ToString());
            int secondDigit = int.Parse(cpfNumbers[10].ToString());

            int cpfSum = 0;
            int firstDigitObtained;
            int secondDigitObtained;

            for (int count = 1; count < 10; count++)
            {
                cpfSum += cpfNumbers[count - 1] * count;
            }

            firstDigitObtained = cpfSum % 11;
            firstDigitObtained = firstDigitObtained == 10 ? 0 : firstDigitObtained;
            

            if (firstDigitObtained != firstDigit)
                return false;

            for (int count = 1; count < 11; count++)
            {
                cpfSum += cpfNumbers[count - 1] * count - 1;
            }

            secondDigitObtained = cpfSum % 11;
            secondDigitObtained = secondDigitObtained == 10 ? 0 : secondDigitObtained;

            if (secondDigitObtained != secondDigit)
                return false;

            return true;
        }
    }

}
