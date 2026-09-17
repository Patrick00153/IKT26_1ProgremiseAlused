namespace ifandelse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("teha üks if and else nestimine iseseisvalt!");
            Console.WriteLine("teise else if-i sisse panna if ja else nestimine");
            //konsool kusib numbrit
            //if vordub 12
            //else if ja siia sisse omakorda teha if ning else. else if tingimused on, et
            //muutuja on suurem kui 20
            //else ja seal valjastab konsoole teksti: mingid kahtlased vaartused


            Console.Write("Sisesta number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number == 12)
            {
                Console.WriteLine("Number võrdub 12");
            }
            else if (number > 20)
            {
                if (number > 100)
                {
                    Console.WriteLine("Number on suurem kui 100");
                }
                else
                {
                    Console.WriteLine("Number on suurem kui 20, aga väiksem või võrdne 100-ga");
                }
            }
            else
            {
                Console.WriteLine("Migid kahtlased väärtused");
            }
        }
    }
}
    

