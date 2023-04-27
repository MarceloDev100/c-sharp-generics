namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintServiceString ps = new PrintServiceString();
            Console.Write("How many values ? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                string x = Console.ReadLine();
                ps.AddValue(x);
            }
          
            ps.Print();
            Console.WriteLine("First: " + ps.First());
        }
    }
}