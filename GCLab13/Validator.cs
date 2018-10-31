using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GCLab13
{
    class Validator
    {
        public static string ValidateChoice()
        {
            string Return = Console.ReadLine();
            try
            {
                if (Return.ToLower() == "r" || Return.ToLower() == "p" || Return.ToLower() == "s"|| Return.ToLower() == "rock" || Return.ToLower() == "paper" || Return.ToLower() == "scissors")
                {
                    return Return;
                }
                else
                {
                    Console.WriteLine("Sorry, that is not valid, try again:");
                    Return = ValidateChoice();
                }

            }
            catch (FormatException)
            {
                Console.Write("That is not valid, try again: ");
                Return = ValidateChoice();
            }
            return Return;

        }
        public static string ValidateDifficulty()
        {
            string Return = Console.ReadLine();
            try
            {
                if (Return.ToLower() == "e" || Return.ToLower() == "r" ||  Return.ToLower() == "easy" || Return.ToLower() == "random")
                {
                    return Return;
                }
                else
                {
                    Console.WriteLine("Sorry, that is not valid, try again:");
                    Return = ValidateDifficulty();
                }

            }
            catch (FormatException)
            {
                Console.Write("That is not valid, try again: ");
                Return = ValidateDifficulty();
            }
            return Return;

        }
        public static string ValidateString()
        {
            string Return = Console.ReadLine();
            try
            {
                if (Regex.IsMatch(Return, @"^[A-z]{0,29}$"))
                {
                    return Return;
                }
                else
                {
                    Console.Write("Sorry, that is not a valid name entry, try again: ");
                    Return = ValidateString();
                }

            }
            catch (FormatException)
            {
                Console.Write("That is not valid name entry, try again: ");
                Return = ValidateString();
            }
            return Return;

        }
    }
}
