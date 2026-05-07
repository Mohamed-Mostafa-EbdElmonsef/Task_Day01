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

            double PriceWithOutTaxes = (SmallCarpets * 25) + (LargeCarpets * 35);

            Console.WriteLine("The price for the small carpet is 25$ ,for large carpet is 35$ and there is Taxes 6% ");
            Console.WriteLine($"The cost without taxes = {PriceWithOutTaxes}");
          
            double Tax_Rate = PriceWithOutTaxes * 0.06;
            double total = PriceWithOutTaxes + Tax_Rate;
            Console.WriteLine($"The cost with taxes = {total:C}");

        }
    }
}
