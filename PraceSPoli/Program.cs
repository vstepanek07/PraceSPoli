namespace PraceSPoli_3SC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //zalozit 3 x promennou pro ulozeni cisla
            //pres consoli nacist hodnoty do promennych
            //vytvorit funkci co spocita prumer a vrati ho
            //tu zavolat a zobrazit vysledek do Console

            int cislo1;
            int cislo2;
            int cislo3 = 0;

            Console.WriteLine("Zadej cislo 1");
            cislo1 = int.Parse(Console.ReadLine());

            //to same jako si rozdelit na:
            //string text = Console.ReadLine();
            //int.Parse(text);

            Console.WriteLine("Zadej cislo 2");
            cislo2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Zadej cislo 3");

            bool jdeOCislo = false;

            while (jdeOCislo == false)
            {
                if (int.TryParse(Console.ReadLine(), out cislo3) == false)
                {
                    Console.WriteLine("Zadana spatna hodnota, nejde o cislo!");
                }
                else
                {
                    jdeOCislo = true;
                }

            }
            //kdyz JdeOCislo bude True (ANO) pak kod pokracuje zde, jinak se opakuje ve smycce



            double prumer = VypocetPrumeru(cislo1, cislo2, cislo3);
            int max = GetMaxValue(cislo1, cislo2, cislo3);
            Console.WriteLine($"Prumer cisel je {prumer}");
            Console.WriteLine($"Maximum cisel je {max}");
            NapisCislo1();

            double VypocetPrumeru(int n1, int n2, int n3)
            {
                double prumer = 0;
                //Kod nebo logika funkce
                prumer = (n1 + n2 + n3) / 3.0; //matematicka operace pouziva cela cisla, jedno z nich musi byt desetinne
                //navrat hodnoty
                return prumer;
                //zkraceno return  (n1 + n2 + n3) / 3;
            }
            void NapisCislo1() //funkce nic nevraci slovo Void, vstupni argumenty nejsou, ale i tak musim pouzit zavorky
            {
                Console.WriteLine("Pisu cislo 1");
            }

            int GetMaxValue(int n1, int n2, int n3)
            {
                int max = n1;
                //
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





        }



    }
}