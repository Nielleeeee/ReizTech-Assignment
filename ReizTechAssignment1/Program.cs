namespace ReizTechAssignment1
{
    internal class Program
    {   
        //Function for computing the lesser angle in an analogue clock 
        public static float lesserAngleCalculator(float hour, float minute)
        {
            //Variables for the minute and hour angle, in this variable I already converted the minute and hour to it's equivalent angle's.
            //I assumed that 12 oclock = 360 degrees, 3 oclock = 90 degrees, 6 oclock = 180, 9 oclock = 270 degrees equivalent in angle.
            float minuteAngle = (minute / 60) * 360;
            float hourAngle = ((hour % 12) / 12) * 360;
            float lesserAngle = 0;


            //This is to calculate the lesser angle, I use if statement to check whether hour or minute has the higher value so that it can always get the lesser angle
            if (hourAngle < minuteAngle)
            {
                return lesserAngle = Math.Abs(minuteAngle - hourAngle);
            }
            return lesserAngle = Math.Abs(hourAngle - minuteAngle);
        }

        //Main Function
        static void Main(string[] args)
        {
            float hour = 0, minute = 0;

            Console.Write("Calculator for lesser angle in degrees between hours arrow and minutes arrow\n");


            //I used while loop for my error handling so that whenever user inserted a wrong input or a number outside the range, it will always ask to put a valid number.
            while (true)
            {
                Console.Write("\nEnter hour (1-12): ");
                if (!float.TryParse(Console.ReadLine(), out hour) || hour < 1 || hour > 12)
                {
                    Console.WriteLine("Invalid input! Please enter a number between 1 and 12.");
                    continue;
                }
                break;
            }

            while (true)
            {
                Console.Write("Enter minute (0-59): ");
                if (!float.TryParse(Console.ReadLine(), out minute) || minute < 0 || minute > 59)
                {
                    Console.WriteLine("Invalid input! Please enter a number between 0 and 59.");
                    continue;
                }
                break;
            }
            Console.WriteLine($"The Lesser Angle of Hour {hour} and Minute {minute} is {lesserAngleCalculator(hour, minute)}");
        }
    }
}