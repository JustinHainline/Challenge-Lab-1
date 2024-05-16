namespace Challenge_Lab_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the temperature: ");
            double temp = Convert.ToDouble(Console.ReadLine());

          

                if (temp < 10)
                {
                    Console.WriteLine("Freezing weather");
                }
                else if (temp >= 11 && temp <= 20)
                {
                    Console.WriteLine("Very Cold weather");
                }
                else if(temp >= 21 && temp <= 35) 
                {
                    Console.WriteLine("Cold weather");
                }
                else if (temp >= 36 && temp <= 50)
                {
                    Console.WriteLine("Normal in weather");
                }
                else if (temp >= 51 && temp <= 65)
                {
                    Console.WriteLine("It's Hot!");
                }
                else if (temp >= 66 && temp <= 80)
                {
                    Console.WriteLine("It's VERY HOT!!");
                }
                else
                {
                    Console.WriteLine("Temperature out of range");
                }
           
        }
    }
}
