namespace exercise8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("enter a max number:");
            int maxNumb = int.Parse (Console.ReadLine());

            for (int i = 0; i < maxNumb; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write("*");
                }
            }
            Console.WriteLine(maxNumb);
        }
    }
}