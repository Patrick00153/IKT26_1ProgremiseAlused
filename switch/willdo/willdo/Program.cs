namespace willdo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("while, Do!");

            int nr = int.Parse(Console.ReadLine());
            int i = 1;
            do
            {
                Console.WriteLine(1);
                //++ liidab uhe numbri juurde eelnevale
                i++;
            } while (i <= nr);
        }
    }
}
