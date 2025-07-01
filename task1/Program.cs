namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number_of_smallCarpets;
            int number_of_largeCarpets;
            int price_per_smallRoom;
            int price_per_largeRoom;
            double cost;
            double tax;
            double total_estimate;
            Console.WriteLine("Number of small carpets:");
            number_of_smallCarpets = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Number of large carpets:");
            number_of_largeCarpets = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Price per small room: $25");
            Console.WriteLine("Price per large room: $35");
            cost = (number_of_smallCarpets * 25) + (number_of_largeCarpets * 35);
            tax = cost * 0.06;
            total_estimate = cost + tax;
            Console.WriteLine("total estimate is : " + total_estimate);
            Console.WriteLine("This estimate is valid for 30 days");

        }
    }
}

