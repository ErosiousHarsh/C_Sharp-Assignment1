using System;

namespace DaysLoop
{
    class Program
    {
        void day(int day)
        {
            int c = 1;
            
                switch (day)
                {
                    case 1:
                        Console.WriteLine("Monday\n");
                        break;

                    case 2:
                        Console.WriteLine("Tuesday\n");
                        break;

                    case 3:
                        Console.WriteLine("Wednesday\n");
                        break;

                    case 4:
                        Console.WriteLine("Thursday\n");
                        break;

                    case 5:
                        Console.WriteLine("Friday\n");
                        break;

                    case 6:
                        Console.WriteLine("Saturday\n");
                        break;

                    case 7:
                        Console.WriteLine("Sunday\n");
                        break;

                    default:
                        Console.WriteLine("Invalid Day");
                        break;
                }
  
        }
        static void Main(string[] args)
        {
            Program pday = new Program();

            int c = 1,day;

            do
            {
                Console.Write("Enter day number: ");
                day = Convert.ToInt32(Console.ReadLine());
                pday.day(day);
                Console.Write("Enter 1 to continue else to exit: ");
                c = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }
            while (c == 1);
        }
    }
}
