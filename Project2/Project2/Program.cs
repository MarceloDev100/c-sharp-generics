using Project2.Entities;
using Project2.Services;
using System.Globalization;

namespace Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                string[] vect = Console.ReadLine().Split(',');
                string name = vect[0];
                double price = double.Parse(vect[1], CultureInfo.InvariantCulture);
                list.Add(new Product(name, price));
            }

            CalculationService cs = new CalculationService();
            Product max = cs.Max(list);
            Console.Write("Max: " + max);
        }
    }
}