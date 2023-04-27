namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintService<int> ps = new PrintService<int>();

            Console.Write("How many values ? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                ps.AddValue(x);
            }

           
            /*
              Now, after using generics, explicit casting is not necessary.
             */
            int a = ps.First();
            
            ps.Print();
            Console.WriteLine("First: " + ps.First());
        }
    }
}