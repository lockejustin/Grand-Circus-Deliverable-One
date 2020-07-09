using System;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            string vacationType = "";
            int groupSize = 0;
            string destination = "";

            do
            {
                Console.WriteLine("What kind of trip would you like to go on?  Please choose from musical, tropical, or adventurous.");
                vacationType = Console.ReadLine();
            } while (vacationType != "musical" && vacationType != "tropical" && vacationType != "adventurous"); //prompts user for type of trip and loops until a proper choice is made

            do
            {
                Console.WriteLine("How many people are in your group?");
                groupSize = int.Parse(Console.ReadLine());
            } while (groupSize <= 0); //prompts user for how many people are in the group and loops back if a number 0 or less is entered


            if (vacationType == "musical")
            {
                destination = "New Orleans";
            }
            else if (vacationType == "tropical")
            {
                destination = "Beach Vacation in Mexico";
            }
            else
            {
                destination = "Whitewater Rafting the Grand Canyon";
            } //reads vacationType variable and determines destination based on the value


            if (groupSize <= 2)
            {
                string result = "Since you're a group of " + groupSize + " going on a " + vacationType + " vacation, you should take a first class flight to " + destination + ".";
                Console.WriteLine(result);
            }
            else if (groupSize <= 5)
            {
                string result = "Since you're a group of " + groupSize + " going on a " + vacationType + " vacation, you should take a helicopter to " + destination + ".";
                Console.WriteLine(result);
            }
            else
            {
                string result = "Since you're a group of " + groupSize + " going on a " + vacationType + " vacation, you should take a charter flight to " + destination + ".";
                Console.WriteLine(result);
            }//outputs groupSize, vacationType, travel type, and destination based on groupSize

            
        }
    }
}
