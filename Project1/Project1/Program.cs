namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintService ps = new PrintService();
            Console.Write("How many values ? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                string x = Console.ReadLine();
                ps.AddValue(x);
            }

            /*
             Despite inserting strings previuosly, compiler will not identify an error in the explicit 
             casting of first element(string) to integer. So, an InvalidCastException will be
             thrown at runtime.
             That's why code below is commented.
            */
            //int a = (int) ps.First();
            //Console.WriteLine(a);

            ps.Print();
            Console.WriteLine("First: " + ps.First());
        }
    }
}