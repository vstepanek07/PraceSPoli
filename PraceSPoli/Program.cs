namespace PraceSPoli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cislo1;
            int cislo2;
            int cislo3;

            Console.WriteLine("Zadejte první číslo:");
            cislo1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Zadejte druhé číslo:");
            cislo2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Zadejte třetí číslo:");
            //cislo3 = int.Parse(Console.ReadLine());

            if (int.TryParse(Console.ReadLine(), out cislo3) == false)
            {
                Console.WriteLine("Třetí číslo bylo zadáno špatně.");
            }
            else
            {
                
            }





        }
    }
}
