namespace whiledotriangel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kolmnurk");
            Console.WriteLine(); // empty line for better look

            int n = 5;          // triangle height (change this number if you want)
            int i = 1;          // row counter

            while (i <= n)      // outer while → controls rows
            {
                int j = 1;      // column counter (stars in current row)

                while (j <= i)  // inner while → prints stars
                {
                    Console.Write("*");
                    j++;
                }

                Console.WriteLine(); // go to next line after finishing the row
                i++;
            }
        }
    }
}
