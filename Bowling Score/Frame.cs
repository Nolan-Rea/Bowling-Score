
using BowlerScorer;
using System.Reflection.Metadata.Ecma335;
using static System.Formats.Asn1.AsnWriter;

namespace BowlerScorer
{
class Frame
{
        public int firstThrow;
        public int secondThrow;
        public int roll;
        public int frameScore;
        public bool isStrike;
        public bool isSpare;

        //Method used for frames 1-9 to populate values for each frame including the value for each throw, and booleans to flag strikes and spares
        public void FillFrame()
        {

            Console.Write("How many pins were knocked down on first throw? ");
            firstThrow = ValidateFirstThrow();
            
            if (firstThrow != 10) {
                Console.Write("How many pins were knocked down on second throw? ");
                secondThrow = ValidateSecondThrow();
            }

  
            frameScore = secondThrow + firstThrow;
            if (frameScore == 10 && secondThrow != 0)
            {
                isSpare = true;
                
            }          
            if (firstThrow == 10)
            {
                isStrike = true;

            }
        }
        // Unique method to create frame 10 as it is the only frame that can allow 3 rolls
        public void frameTen()
        {
            int thirdThrow = 0;

            Console.Write("How many pins were knocked down on first throw? ");
            firstThrow = ValidateFirstThrow();

            Console.Write("How many pins were knocked down on second throw? ");
            if(firstThrow == 10)
            {
                secondThrow = ValidateFirstThrow();
            }
            else
            {
                secondThrow = ValidateSecondThrow();
            }

            if(firstThrow + secondThrow>= 10 && firstThrow + secondThrow <= 20)
            {
                Console.Write("How many pins were knocked down on third throw? ");
                thirdThrow = ValidateFirstThrow();
            }
            frameScore = thirdThrow + secondThrow + firstThrow;
        }
        //Validation to ensure a roll is a valid number between 1 and 10 inclusively
        public int ValidateFirstThrow()
        {
         while(!int.TryParse(Console.ReadLine(), out roll) || roll > 10 || roll < 0)
            {   
                Console.Write("Invalid Input! Enter a number between 0 and 10: ");  
            }
            return roll;
        }
        //Validation to ensure a roll is a valid number and is no bigger than the possible amount of pins left to be hit
        public int ValidateSecondThrow()
        {
            while (!int.TryParse(Console.ReadLine(), out roll) || roll > 10 - firstThrow || roll < 0)
            {
                Console.Write($"Invalid Input! Enter a number between 0 and {10 - firstThrow} : ");   
            }
            return roll;
        }
    }
}

