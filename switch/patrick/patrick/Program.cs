namespace patrick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vali tegevus:");
            Console.WriteLine("1 - Liitmine");
            Console.WriteLine("2 - Kuva tekst \"Auh\"");
            Console.WriteLine("3 - Küsi nime");
            Console.Write("Sisesta valik (1, 2 või 3): ");

            string valik = Console.ReadLine();

            switch (valik)
            {
                case "1":
                    Console.Write("Sisesta esimene number: ");
                    double a = double.Parse(Console.ReadLine());

                    Console.Write("Sisesta teine number: ");
                    double b = double.Parse(Console.ReadLine());

                    Console.WriteLine("Vastus: " + (a + b));
                    break;

                case "2":
                    KuvaAuh();
                    break;

                case "3":
                    Console.Write("Mis on sinu nimi? ");
                    string Patrick = Console.ReadLine();
                    Console.WriteLine("Tere, " + Patrick + "!");
                    break;

                default:
                    Console.WriteLine("Vale valik! Palun vali 1, 2 või 3.");
                    break;
            }

            Console.WriteLine("\nVajuta suvalist klahvi, et programm sulgeda...");
            Console.ReadKey();
        }

        static void KuvaAuh()
        {
            Console.WriteLine("Auh");
        }
    }
}