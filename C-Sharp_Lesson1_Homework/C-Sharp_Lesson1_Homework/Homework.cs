using System;

namespace C_Sharp_Lesson1_Homework
{
    class Homework
    {
        public void CheckIfNumberIsEvenOrOdd(int number)
        {
            /* Exercise 1
          * using "if" write a programm that checks whether an integer is greater then zero and even or odd
          * Example:
          * -------------------------------------------------
          * |input   | result                               |
          * |--------|--------------------------------------|
          * |  1     | odd                                  |
          * |--------|--------------------------------------|
          * |  2     | even                                 |
          * |--------|--------------------------------------|
          * | -1     | the value should be greater then zero|
          * -------------------------------------------------
          * 
          */
            if (number > 0 && number % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else if (number > 0 && number % 2 != 0)
            {
                Console.WriteLine("Odd");
            }
            else
            {
                Console.WriteLine("The value should be grater than zero");
            }

        }
        public void NumberDivideToFour(int number)
        {
            /* Exercise 2
        * using a ternary operator write a program that print if number divide to 4
        * Example: 
        * --------------------------------------------
        * |input   | result                          |
        * |--------|---------------------------------|
        * |  -4    | The number divide to 4          |
        * |--------|---------------------------------|
        * |   2    | The number doesn't divide to 4  |
        * --------------------------------------------
        */
            var result = number % 4 == 0 ? "The number divide to 4" : "The number doesn`t divide to 4";
            Console.WriteLine(result);
        }
        public void DayOfWeek(string day)
        {
            /* Exercise 3
             * using "switch" statement write a program that print the number of day of week
             * Example: monday - 1, tuesday - 2 etc. 
             * ---------------------------------------------------------
             * |day           |number                                  |
             * |--------------|----------------------------------------|
             * |monday        |   1                                    |
             * |tuesday       |   2                                    |
             * |wednesday     |   3                                    |
             * |thursday      |   4                                    |
             * |friday        |   5                                    |
             * |saturday      |   6                                    |
             * |sunday        |   7                                    |
             * |default value |Wrong value! Please give a day of a week|
             * ---------------------------------------------------------
             */

            switch (day)
            {
                case "Monday":
                    Console.WriteLine(day + '-' + 1);
                    break;
                case "Tuesday":
                    Console.WriteLine(day + '-' + 2);
                    break;
                case "Wednesday":
                    Console.WriteLine(day + '-' + 3);
                    break;
                case "Thursday":
                    Console.WriteLine(day + '-' + 4);
                    break;
                case "Friday":
                    Console.WriteLine(day + '-' + 5);
                    break;
                case "Saturday":
                    Console.WriteLine(day + '-' + 6);
                    break;
                case "Sunday":
                    Console.WriteLine(day + '-' + 7);
                    break;
                default:
                    Console.WriteLine("Please give a day of week");
                    break;
            }
        }
        public void CheckLetterIfVowel(char character)
        {
            /* Exercise 4
             * write a program that will print input character is a vowel, consonant or not a letter
             * Method 1: using a switch case
             * Method 2: using if
             * ---------------------------
             * |input| result            |
             * |-----|-------------------|
             * |  a  | a is a vowel      |
             * |  b  | b is a consonant  |
             * ---------------------------
             */
            // Method 1: using switch case

            if ((character >= 'a' && character <= 'z') || (character >= 'A' && character <= 'Z'))

            {
                switch (character)
                {
                    case 'a':
                        Console.WriteLine(character + " is a vowel");
                        break;
                    case 'e':
                        Console.WriteLine(character + " is a vowel");
                        break;
                    case 'i':
                        Console.WriteLine(character + " is a vowel");
                        break;
                    case 'o':
                        Console.WriteLine(character + " is a vowel");
                        break;
                    case 'u':
                        Console.WriteLine(character + " is a vowel");
                        break;
                    case 'A':
                        Console.WriteLine(character + " is a vowel");
                        break;
                    case 'E':
                        Console.WriteLine(character + " is a vowel");
                        break;
                    case 'I':
                        Console.WriteLine(character + " is a vowel");
                        break;
                    case 'O':
                        Console.WriteLine(character + " is a vowel");
                        break;
                    case 'U':
                        Console.WriteLine(character + " is a vowel");
                        break;
                    default:
                        Console.WriteLine(character + " is a consonant");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Is not a letter");
            }


            // Method 2: using if

            if (character == 'a' || character == 'o' || character == 'u' || character == 'e' || character == 'i')
            {
                Console.WriteLine(character + " is a vowel");
            }
            else if (character > 'a' && character <= 'z')
            {
                Console.WriteLine(character + " is a consonant");
            }
            else
            {
                Console.WriteLine("Is not a letter");
            }


        }
        public static void Main(String[] args)
        {
            Homework homework = new Homework();

            homework.CheckIfNumberIsEvenOrOdd(-11);
            homework.CheckIfNumberIsEvenOrOdd(11);
            homework.CheckIfNumberIsEvenOrOdd(8);
            //---------------------------------------
            homework.NumberDivideToFour(10);
            homework.NumberDivideToFour(16);
            //---------------------------------------
            homework.DayOfWeek("Monday");
            homework.DayOfWeek("Sunday");
            homework.DayOfWeek("some day");
            //---------------------------------------
            homework.CheckLetterIfVowel('p');
            homework.CheckLetterIfVowel('i');

        }
    }
}
