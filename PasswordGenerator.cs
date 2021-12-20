using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StrongPasswordGenerator
{
    internal class PasswordGenerator
    {
        static char[] LowerCaseArray;
        static char[] UpperCaseArray;
        static char[] NumbersArray;
        static char[] SymbolsArray;

        static Random randomNumberGen = new Random();

        CheckBox incudeSymbols;
        NumericUpDown passwordLengthInput;

        #region Constructor
        public PasswordGenerator(CheckBox includeSymbolsCheckbox, NumericUpDown passwordLengthValue)
        {
            incudeSymbols = includeSymbolsCheckbox;
            passwordLengthInput = passwordLengthValue;

            passwordLengthInput.Value = SetPasswordLength();
        }
        #endregion

        #region Password Creation
        public string GeneratePassword()
        {
            int passwordLength = SetPasswordLength();

            passwordLengthInput.Value = passwordLength;

            PopulateCharacterArrays(passwordLength);

            return CreatePassword(passwordLength);
        }

        private string CreatePassword(int length)
        {
            char pulledChar;
            string password = "";

            for (int i = 0; i < length; i++)
            {
                switch (randomNumberGen.Next(IncludeSymbols()))
                {
                    case 0:
                        pulledChar = LowerCaseArray[randomNumberGen.Next(LowerCaseArray.Length)];
                        password += pulledChar;
                        break;

                    case 1:
                        pulledChar = UpperCaseArray[randomNumberGen.Next(UpperCaseArray.Length)];
                        password += pulledChar;
                        break;

                    case 2:
                        pulledChar = NumbersArray[randomNumberGen.Next(NumbersArray.Length)];
                        password += pulledChar;
                        break;

                    case 3:
                        pulledChar = SymbolsArray[randomNumberGen.Next(SymbolsArray.Length)];
                        password += pulledChar;
                        break;
                }
            }

            return password;
        }

        private static void PopulateCharacterArrays(int passwordLength)
        {
            int arraysToPopulate = 3;

            for (int i = 0; i <= arraysToPopulate; i++)
            {
                switch (i)
                {
                    case 0:
                        LowerCaseArray = CreateRandomCharacterArray(CharacterLists.LowerCase, passwordLength);
                        break;
                    case 1:
                        UpperCaseArray = CreateRandomCharacterArray(CharacterLists.UpperCase, passwordLength);
                        break;
                    case 2:
                        NumbersArray = CreateRandomCharacterArray(CharacterLists.Numbers, passwordLength);
                        break;
                    case 3:
                        SymbolsArray = CreateRandomCharacterArray(CharacterLists.Symbols, passwordLength);
                        break;
                }
            }
        }

        private int IncludeSymbols()
        {
            if (incudeSymbols.Checked)
                return 4;
            else
                return 3;
        }

        private static char[] CreateRandomCharacterArray(List<char> characterList, int arraySize)
        {
            char[] randomCharacterArray = new char[arraySize];

            for (int i = 0; i < randomCharacterArray.Length; i++)
            {
                randomCharacterArray[i] = characterList[randomNumberGen.Next(characterList.Count)];
            }

            return randomCharacterArray;
        }
        #endregion

        #region Password Length
        private int SetPasswordLength()
        {
            int minLength = 8;
            int maxLength = 30;
            int length;

            if (GetInputAsInt() > maxLength)
            {
                length = maxLength;
            }
            else if (GetInputAsInt() < minLength)
            {
                length = minLength;
            }
            else
            {
                length = GetInputAsInt();
            }

            return length;
        }

        private int GetInputAsInt()
        {
            decimal originalValue = passwordLengthInput.Value;
            int convertedValue = Convert.ToInt32(originalValue);

            return convertedValue;
        }
        #endregion
    }
}
