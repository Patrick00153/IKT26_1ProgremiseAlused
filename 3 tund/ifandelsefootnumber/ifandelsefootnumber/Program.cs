namespace ifandelsefootnumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //teha jalanumbri suurusest uks if ja else harjutus
            //esimene tingimus on jalanumbri 30-33 (siin on tekst roheline)
            //teine jalanumbri 34-38 (siin on tagataust valge)
            //kolmas jalanumbri 39-44 (siin on teks sinine ja tagataust kollane)
            //neljas jalanumbri 45-48 (siin teeb arvuti haalt beep)
            //kindlasti tuleb ara lahendada olukord
            //kus kasutatakse mõnda teist jalanumbrit

            Console.WriteLine("Sisesta jalanumber:");
            int jalanumber = Convert.ToInt32(Console.ReadLine());

            if (jalanumber >= 30 && jalanumber <= 33)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Jalanumber on vahemikus 30-33");
            }
            else if (jalanumber >= 34 && jalanumber <= 38)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine("jalanumber on vahemikus 34-38");
            }
            else if (jalanumber >= 39 && jalanumber <= 44)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Jalanumber on vahemikus 39-44");
            }
            else if (jalanumber >= 45 && jalanumber <= 48)
            {
                Console.Beep();
                Console.WriteLine("Jalanumber on vahemikus 45-48");
            }
            else if (jalanumber >= 49 && jalanumber <= 55)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("jalanumber on vahemikus 49-55");
            }
        }
    }
}
        
    

