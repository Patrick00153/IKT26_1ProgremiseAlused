namespace IfAndElse
{
    //Projekti nimetusega IfAndElse, mille sees asub class nimega Program. Seeklass  sisaldab Main meetodit, mis on programmi sisenemispunkt
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta enda nimi:");
            //muutuja nimega name, kuhu salvestatakse kasutaja
            //sisestatud tekst
            string name = Console.ReadLine();
            //! tähendab "ei ole" ja == tähendab "on võrdne" 
            if (name != "")
            {
                Console.WriteLine("Sisestasid enda nime");
                Console.WriteLine(name);
            }
            else
            {

            }            
               Console.WriteLine("ERROR.Nime ei sisestanud");
            if (name != "")
            {
                Console.WriteLine("Sisestasid enda nime");


            }
            }
        }
    }
}
