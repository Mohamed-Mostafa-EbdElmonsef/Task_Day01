namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Islam Carpet Cleaning Service");
            Console.WriteLine("We offer Carpet Cleaning Service : 25$ for small carpets and 35$ for large carpet");
            Console.Write("Enter the number of small carpets :");
            int SmallCarpets = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number of large carpets :");
            int LargeCarpets = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The price for the small carpet is 25$ ,for large carpet is 35$ and there is Taxes 6.6$");
            Console.WriteLine($"The cost without taxes = {(SmallCarpets*25)+(LargeCarpets*35)}");
            Console.WriteLine($"The cost with taxes = {(SmallCarpets*25)+(LargeCarpets*35)+6.6}");

        }
    }
}
