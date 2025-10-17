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

            Console.WriteLine("Zadejte třetí číslo:");
            //cislo3 = int.Parse(Console.ReadLine());
            bool jdeoCislo = false;
            while (jdeoCislo == false)
            {

                if (int.TryParse(Console.ReadLine(), out cislo3) == false)
                {
                    Console.WriteLine("Třetí číslo bylo zadáno špatně. Zadejte číslo znovu:");
                }
                else
                {
                    jdeoCislo = true;
                }

                
            }
                
            



            double VypocetPrumeru(int n1, int n2, int n3)
            {
                double prumer = 0;
                prumer = (n1 + n2 + n3) / 3;

                return prumer;



            }
            

            double prumer = VypocetPrumeru(cislo1, cislo2, cislo3);

            Console.WriteLine($"Průměr zadaných čísel je: {prumer} ");
            
            int max = GetMaxValue(cislo1, cislo2, cislo3);
            int GetMaxValue(int n1, int n2, int n3)
            {
                int max = n1;
                if (n2 > max)
                {
                    max = n2;
                }
                if (n3 > max)
                {
                    max = n3;

                }
                return max;
            }
            Console.WriteLine("Největší zadané číslo je: " + max);
            Console.WriteLine(GetMaxValue(cislo1, cislo2, cislo3));
            
            
           
        }
    }
}
