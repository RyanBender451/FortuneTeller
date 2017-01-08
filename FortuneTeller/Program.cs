//Ryan J. Bender
//Project Fortune Teller For We Can Code IT 
//Cleveland Winter Class of 2017

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    class Program
    {
        //Fortune Teller Program
        /*
         * This program takes information from the user and uses it to create a fortune
        */
        static void Main(string[] args)
        {
            //Part 1 get the information
            Console.WriteLine("Please Enter your First Name");
            string firstName = Console.ReadLine();

            Console.WriteLine("Please Enter your Last Name");
            string lastName = Console.ReadLine();

            Console.WriteLine("How old are you?");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("What is the number of the Month you were born in:");
            int bMonth = int.Parse(Console.ReadLine());

            Console.WriteLine("Pick your favorite ROYGBIV.  If you don't know what ROYGBIV is type in Help");
            string cRainbow = Console.ReadLine();

            if (cRainbow.ToUpper() == "HELP")
            {
                Console.WriteLine("ROYGBIV is the color rainbow");
                Console.WriteLine("R is Red \nO is Orange \nY is Yellow \nG is Green \nB is Blue \nI is Indigo \nV is Violet");
                Console.WriteLine("Please enter a ROYGBIV color");
                cRainbow = Console.ReadLine();

            }
            
            //Number of Siblings
            Console.WriteLine("Please enter the number of Siblings you have");
            int siblingsNum = int.Parse(Console.ReadLine());
            //End part 1

            //Part 2 manipulating the data
            //Retire in x years
            string retireYears;
            if (age%2 == 0)
            {
                 retireYears = "25 years";
            }
            else
            {
                 retireYears = "42 years";
            }
            
            //Vaction Home data based on number of siblings
            string vacHome;
            if (siblingsNum <0)
            {
                vacHome = "Antarctica";
            }
            else
            {
                switch (siblingsNum)
                {
                    case 0:
                        vacHome = "Orlando Florida";
                    break;

                    case 1:
                        vacHome = "Paris France";
                    break;

                    case 2:
                        vacHome = "Rome Italy";
                    break;

                    case 3:
                        vacHome = "New York";
                    break;

                    default:
                        vacHome = "Cancun Mexico";
                    break;

                }
            }
            
            //ROYGBIV and mode of transportation
            string transportColor;
            switch (cRainbow.ToUpper())
            {
                case "RED":
                    transportColor = "Chevy Corevette";
                break;

                case "ORANGE":
                    transportColor = "Ford Mustang";
                break;

                case "YELLOW":
                    transportColor = "Pink Cadillac";
                break;

                case "GREEN":
                    transportColor = "Ford F-150";
                break;

                case "BLUE":
                    transportColor = "Dodge RAM";
                break;

                case "INDIGO":
                    transportColor = "Jeep Wrangler";
                break;

                case "VIOLET":
                    transportColor = "Volkswagon Beetle";
                break;

                //The default is used for any other color besides the 'valid' colors with a ludicrious transportation
                default:
                    transportColor = "Larry the Riding Llama";
                break;
            }
            //Birth Month and cash in bank
            string cashBank;
            if(bMonth >= 1 && bMonth <= 4)
            {
                cashBank = "$40000.67";
            }
            else if(bMonth >=5 && bMonth <= 8)
            {
                cashBank = "$65000.98";
            }
            else if(bMonth >= 9 && bMonth <= 12)
            {
                cashBank = "$91000.24";
            }
            else
            {
                cashBank = "$0.00";
            }


            //Part 3
            Console.WriteLine("Zoltar has read your Future!");
            Console.WriteLine(firstName + " " + lastName + " will retire in " + retireYears + " with " + cashBank + " in the bank, a vaction home in " +  vacHome + " and a " + transportColor);
           
        }
    }
}
 