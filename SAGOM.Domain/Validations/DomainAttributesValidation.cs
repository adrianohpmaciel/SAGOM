using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SAGOM.Domain.Validations
{
    public static class DomainAttributesValidation
    {
        public static string GetOnlyNumbers(string numbers)
        {
            Regex toObtainOnlyNumbers = new Regex(@"[^\d]");
            return toObtainOnlyNumbers.Replace(numbers, "");
        }

        public static string GetOnlyLetters(string letters)
        {
            Regex toObtainOnlyLetters = new Regex("[^a-zA-Z]+");
            return toObtainOnlyLetters.Replace(letters, "");
        }

        public static bool IsOnlyNumber(string numbers)
        {
            numbers = numbers.Trim();
            string filteredNumbers = GetOnlyNumbers(numbers);

            if (filteredNumbers.Length == 0 || filteredNumbers.Length != numbers.Length)
                return false;

            return true;
        }

        public static bool IsOnlyLetters(string letters)
        {
            letters = letters.Trim().Replace(" ", "");
            string filteredLetters = GetOnlyLetters(letters);

            if (filteredLetters.Length == 0 || filteredLetters.Length != letters.Length)
                return false;

            return true;
        }
    }
}

