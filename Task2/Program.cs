namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> L = new List<int>();
            int sum = 0;
            string SelectedOption="";


            while (SelectedOption != "Q")
            {
                Console.WriteLine("Select your option ");
                Console.WriteLine(" P - Print numbers");
                Console.WriteLine(" A - Add a number");
                Console.WriteLine(" M - Display mean of the numbers");
                Console.WriteLine(" S - Display the smallest number");
                Console.WriteLine(" L - Display the largest number");
                Console.WriteLine(" F - Find a number in the list");
                Console.WriteLine(" C - Clear the list");
                Console.WriteLine(" O - Order list");
                Console.WriteLine(" Q - Quit");
                Console.Write("Enter your choice : ");
                SelectedOption = Console.ReadLine().ToUpper();

                switch (SelectedOption)
                {
                    case "P":
                        if(L.Count != 0) 
                        { 
                        Console.Write("[");
                        foreach (int item in L)
                            Console.Write(item + " ");
                        Console.WriteLine("]");
                        }
                        else
                            Console.WriteLine("[] - the list is empty");
                        break;

                    case "A":
                        int num = 0;
                        Console.WriteLine("Enter the number to add");
                        num = Convert.ToInt32(Console.ReadLine());
                        if (!(L.Contains(num)))
                        { 
                        L.Add(num);
                        Console.WriteLine($"{num} is added to the list ");
                        }
                        else
                            Console.WriteLine($"{num} is already exsit !!");
                        break;

                    case "M":
                        if (L.Count != 0)
                        { 
                        foreach(int item in L)
                            sum += item;
                        Console.WriteLine($"the average of the list = {sum/L.Count}");
                        }
                        else
                            Console.WriteLine("Unable to calculate the mean - no data");
                        break;

                    case "S":
                        if (L.Count != 0)
                        {
                            int Min_Number = int.MaxValue;
                            foreach (int item in L)
                                if (item < Min_Number)
                                    Min_Number = item;
                            Console.WriteLine($"The smallest number is  {Min_Number}");
                        }
                        else
                            Console.WriteLine("Unable to determine the smallest number - list is empty");
                        break;

                    case "L":
                        if (L.Count != 0)
                        { 
                        int Max_Number = 0;
                        foreach (int item in L)
                            if (item > Max_Number)
                                Max_Number = item;
                        Console.WriteLine($"The largest number is {Max_Number}");
                        }
                        else
                            Console.WriteLine("Unable to determine the largest number - list is empty");
                        break;
                    case "F":
                        Console.Write("Enter a number to find : ");
                        int n = Convert.ToInt32(Console.ReadLine());
                        if(L.Count != 0)
                        {   
                            Console.WriteLine($"{n} found at index = {L.IndexOf(n)}");
                        }
                        else
                            Console.WriteLine("Unable to find the number - list is empty");
                        break;
                        
                    case "C":
                        if (L.Count != 0)
                        { 
                            L.Clear();
                            Console.WriteLine("The list cleared");
                        }
                        else
                            Console.WriteLine("The list is already empty !!");
                        break;
                    case "O":
                        int temp;
                                                                     
                        for(int i =0 ; i < L.Count ; i++)
                        {
                            for (int j = 0; j < L.Count; j++)
                            {
                                if (L[i] < L[j])
                                {
                                    temp = L[i];
                                    L[i]=L[j];
                                    L[j] = temp;

                                }
                            }
                        }
                        Console.WriteLine("The list is ordered");
                        break;
                    case "Q":
                        
                        Console.WriteLine("Goodbye!!"); 
                        break;

                    default:
                        Console.WriteLine("Unknown selection, please try again");
                       
                        break;
                }
                 
            }

           
        }
    }
}
