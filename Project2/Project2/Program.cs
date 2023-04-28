using Project2.Services;

namespace Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                list.Add(number);
            }

            CalculationService cs = new CalculationService();
            int max = cs.Max(list);
            Console.Write("Max: " + max);
        }
    }
}