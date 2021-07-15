using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamilton_Tevin_CountCart
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Tevin Hamilton
             * 03/11/2018
             * Count The Cart Assignment 
             * */
            Console.Clear();
             //creating a new string array with 10 stings 
            string[] itemsArrayString = new string[10] { "snack", "drink", "vegetable", "drink", "meat", "snack", "vegetable", "snack", "drink", "drink" };

            //create a output to the user before they make a choice 
            Console.WriteLine("please choose one of the following items.\r\nChoose (1) for snacks.\r\nchoose (2) for Drinks.\r\nChoose (3) for vegetables\r\nChoose (4) for Meats.");

            //capture the user responeds 
            string userChoiceString = Console.ReadLine();
            int userChoice;

            while (!int.TryParse(userChoiceString,out userChoice) || (userChoice < 1) || (userChoice > 4))
            {
                Console.WriteLine("please don't leave blank\r\nenter a whole number\r\nUse numbers 1 - 4 ");

                userChoiceString = Console.ReadLine();
            }
            int num = 0;
            //create if and else statements
            if (UserChoice == 1)
            {
                
                //using a for loop to count 
                for (int i = 0; i < itemsArrayString.Count(); i++)
                {
                    if ("snack" == itemsArrayString[i] )
                    {
                        num++;                       
                    }
                }
                Console.WriteLine($"in the shoping cart there are {num} {itemsArrayString[0]} ");
            }

            else if (userChoice == 2 )
            {
                for (int i = 0; i < itemsArrayString.Count(); i++)
                {
                    if ("drink" == itemsArrayString[i])
                    {
                        num++;
                    }
                }
                Console.WriteLine($"in the shoping cart there are {num} {itemsArrayString[1]} ");
            }

            else if (userChoice == 3)
            {
                for (int i = 0; i < itemsArrayString.Count(); i++)
                {
                    if ("vegetable" == itemsArrayString[i])
                    {
                        num++;
                    }
                }
                Console.WriteLine($"in the shoping cart there are {num} {itemsArrayString[2]} ");
            }

            else if (userChoice == 4)
            {
                for (int i = 0; i < itemsArrayString.Count(); i++)
                {
                    if ("meat" == itemsArrayString[i])
                    {
                        num++;
                    }
                }
                Console.WriteLine($"in the shoping cart there are {num} {itemsArrayString[4]} ");

            }

            


        }
    }
}
