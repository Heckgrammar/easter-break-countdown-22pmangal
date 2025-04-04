namespace BlankCSDotNet8
{
    internal class Program
    {
        static void Main(string[] args)
        {


            DateTime current = DateTime.Now;
            Console.WriteLine("The current date and time is : "); Console.WriteLine(current);
            DateTime target = new DateTime(2025, 4, 6, 15, 15, 0);
            Console.WriteLine("The target date and time is : "); Console.WriteLine(target);
            TimeSpan difference = target - current;
            if (difference.Seconds < 0)
            {
                Console.WriteLine("Spring break has started");
            }else
            {
                if (difference.Days > 0)
                {
                    int daysleft = difference.Days;
                    Console.WriteLine(" There is " + difference.Days + " Days, " + (difference.Hours /*+ daysleft * 24*/) + " hours, " + difference.Minutes + " minutes and " + difference.Seconds + " seconds left until the target time is reached");
                }
                else
                {
                    Console.WriteLine("There is " + difference.Hours + " hours, " + difference.Minutes + " minutes and " + difference.Seconds + " seconds left");
                }
            }
           

        }
    }
}         