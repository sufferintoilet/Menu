internal class Program
{
    private static void Main(string[] args)
    {
        int choice = -1;
        while (choice!=0)
        {
            Console.WriteLine("enter a number from keyboard");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {   
                case 1:
                {
                    Console.WriteLine("**********");
                    Console.WriteLine("*********");                    
                    Console.WriteLine("********");
                    Console.WriteLine("*******");
                    Console.WriteLine("******");
                    Console.WriteLine("*****");
                    Console.WriteLine("****");
                    Console.WriteLine("***");
                    Console.WriteLine("**");
                    Console.WriteLine("*");

                }
                break;
                case 2:
                {
                    Console.WriteLine("**********");
                    Console.WriteLine("**********");
                    Console.WriteLine("**********");
                    Console.WriteLine("**********");
                    Console.WriteLine("**********");
                }
                break;
                case 3:
                {
                    Console.WriteLine("**********");
                    Console.WriteLine("**********");
                    Console.WriteLine("**********");
                }
                break;
                case 0: Environment.Exit(0);
                break;
                default: Console.WriteLine("type again");
                break;
            }
        }
    }
}