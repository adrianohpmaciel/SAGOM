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
        public string Cpf { get; private set; }
        public string Name { get; private set; }
        public string LastName { get; private set; }
        public string Address { get; private set; }
        public string CellPhone { get; private set; }

        public Person(string cpf, string name, string lastName, string address, string cellPhone)
        {
            ValidateDomain(cpf, name, lastName, address, cellPhone);
            Cpf = cpf;
            Name = name;
            LastName = name;
            Address = address;
            CellPhone = cellPhone;
        }

        private void ValidateDomain(string cpf, string name, string lastName, string address, string cellPhone)
        {
            DomainExceptionValidation.When(String.IsNullOrEmpty(cpf), "Invalid CPF. CPF is required");
            DomainExceptionValidation.When(cpf.Length < 9, "Invalid CPF, too short, minimum 9 characters");
            DomainExceptionValidation.When(isValidCpf(cpf), "Invalid CPF, verify the inserted value");

            DomainExceptionValidation.When(String.IsNullOrEmpty(name), "Invalid Name. Name is required");
            DomainExceptionValidation.When(name.Length < 3, "Invalid Name, too short, minimum 3 characters");

            DomainExceptionValidation.When(String.IsNullOrEmpty(lastName), "Invalid LastName. LastName is required");
            DomainExceptionValidation.When(lastName.Length < 3, "Invalid LastName, too short, minimum 3 characters");

            DomainExceptionValidation.When(String.IsNullOrEmpty(address), "Invalid address. address is required");
            DomainExceptionValidation.When(address.Length < 3, "Invalid address, too short, minimum 3 characters");

            DomainExceptionValidation.When(String.IsNullOrEmpty(cellPhone), "Invalid cellPhone. address is required");
            DomainExceptionValidation.When(cellPhone.Length < 12, "Invalid address, too short, minimum 11 characters");

        }

        private bool isValidCpf(string cpf)
        {
            char[] cpfClean = cpf.Replace(".", "").Replace("-", "").Replace("/", "").ToCharArray();
            char[] cpfDigits = new char[2];

            int cpfLength = cpfClean.Length;
            int cpfSum = 0;
            int firstDigit;
            int secondDigit;
            int testValue;

            if (cpfLength != 11)
                return false;

            foreach(char c in cpfClean)
            {
                if (int.TryParse(c.ToString(), out testValue) == false)
                    return false;
            }

            cpfDigits[0] = cpfClean[9];
            cpfDigits[1] = cpfClean[10];
            

            for (int count = 1; count < 10; count++)
            {
                cpfSum += cpf[count - 1] * count;
            }

            firstDigit = cpfSum % 11;

            if (firstDigit != cpfDigits[0])
                return false;

            for (int count = 1; count < 11; count++)
            {
                cpfSum += cpf[count - 1] * count - 1;
            }

            secondDigit = cpfSum % 11;

            if (secondDigit != cpfDigits[1])
                return false;


            return true;
        }
    }

}
