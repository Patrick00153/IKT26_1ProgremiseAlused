namespace SwitchRandomNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Täringu viskamise mäng");

            //Random genereerib iga kord suvalise nr 1-st kuni 6-ni
            int cube = new Random().Next(1, 6);

            switch (cube)
            {
                case 1:
                    Console.WriteLine("Tuli 1");
                    break;
                case 2:
                    Console.WriteLine("Tuli 2");
                    break;
                case 3:
                    Console.WriteLine("Tuli 3");
                    break;
                case 4:
                    Console.WriteLine("Tuli 4");
                    break;
                case 5:
                    Console.WriteLine("Tuli 5");
                    break;
                case 6:
                    Console.WriteLine("Tuli 6");
                    break;
            }
        }
    }
}