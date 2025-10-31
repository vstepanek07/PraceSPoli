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
            // Toto funguje jen pro tri cisla
            //universalne na 100 cisel
            //zakladam pole (array)
            int velikostPole = 100;
            //int[] cisla = new int[100];



            //Console.WriteLine(cisla[0]);
            //Console.WriteLine(cisla[5]); //Nic jsem tam nezadal ale pri vzniku se zada 0
            //Console.WriteLine(cisla[100]);//spadne, pozice s indexem 100 neexistuje
            //Console.WriteLine(cisla); //Nespadne, ale napise systemovy typ promenny

            Console.WriteLine("Kolik budes zadavat cisel?");
            velikostPole = int.Parse(Console.ReadLine());
            int[] cisla = new int[velikostPole];
            //cisla[0] = 1;
            //cisla[1] = 5;

            string[] jmenaStudentu = new string[10];
            jmenaStudentu[0] = "Vaclav";
            jmenaStudentu[1] = "Adam";
            jmenaStudentu[2] = "Kuba";
            jmenaStudentu[3] = "Petr";
            jmenaStudentu[4] = "Jirka";
            //jmenaStudentu[10] = "Tomas";

            int indexCounter = 0;


            while (indexCounter < jmenaStudentu.Length)
            {

                string mostFrequentName = "";
                int count = 0;
                mostFrequentName = jmenaStudentu[indexCounter];
                int indexCounter2 = 0;
                while (indexCounter2 < jmenaStudentu.Length)
                {
                    if (jmenaStudentu[indexCounter2] == mostFrequentName)
                    {
                        count++;
                    }
                    indexCounter2++;

                }

                indexCounter++;


            }





            int currentIndex = 0;

            while (currentIndex < velikostPole)
            {
                Console.WriteLine($"zadej cislo {currentIndex + 1}");
                int tempCislo = int.Parse(Console.ReadLine());
                cisla[currentIndex] = tempCislo;
                currentIndex++; // ++ = currentIndex = currentIndex + 1
            }

            Console.WriteLine($"Prumer cisle je {LepsiVypocetPrumeru(cisla)}");
            Console.WriteLine($"Maximalni cislo je {LepsiGetMaxValue(cisla)}");
            Console.WriteLine($"Zadany nasledujici cisla: {VypisVsechnyHodnotyPoleOddeleneCarkou(cisla)}");
            //
            double LepsiVypocetPrumeru(int[] cislaIn)
            {
                double prumer = 0;
                int soucetCisel = 0;

                int velikostPole = cislaIn.Length;//Zjisti velikost pole ktere posle uyivatel funkce
                int currentIndex = 0;
                while (currentIndex < velikostPole)
                {
                    soucetCisel = soucetCisel + cislaIn[currentIndex];
                    currentIndex++;
                }
                prumer = soucetCisel / (double)velikostPole;
                return prumer;
            }
            int LepsiGetMaxValue(int[] cislaIn)
            {
                int maxValue = 0;
                int currentIndex = 0;
                //zjisti velikost pole pomoci vlastnosti "Length"
                int velikostPole = cislaIn.Length;
                if (velikostPole == 0)
                {
                    return -1;
                }
                else
                {
                    maxValue = cislaIn[0]; //<<<<<<<<<<<< bezna praxe inicializovat neco na prvni pole
                    while (currentIndex < velikostPole)
                    {
                        if (cislaIn[currentIndex] > maxValue)
                        {
                            maxValue = cislaIn[currentIndex];
                        }
                        currentIndex++;
                    }
                    return maxValue;

                }


                //projit postupne kazde policko
                //Pokud je hodnota v poli vetsi nez maxValue tak zadat jako maxValue hodnotu v cislaIn[currentIndex]



            }
            string VypisVsechnyHodnotyPoleOddeleneCarkou(int[] cislaIn)
            {
                string hodnoty = "";

                int velikostPole = cislaIn.Length;//Zjisti velikost pole ktere posle uyivatel funkce
                int currentIndex = 0;
                while (currentIndex < velikostPole)
                {
                    if (currentIndex == 0)
                    {
                        hodnoty = hodnoty + cislaIn[currentIndex];
                    }
                    else
                    {
                        hodnoty = hodnoty + "," + cislaIn[currentIndex];
                    }
                    currentIndex++;
                }


                //zjistit velikost pole pokud je nula vratit ""
                //pokud ne tak ve smycce projet hodnoty pridat "," + hodnotu
                //hodnoty = "," + cislaIn[0];

                return hodnoty;
            }

            //Console.WriteLine("Zadej cislo 1");
            //cislo1 = int.Parse(Console.ReadLine());

            //to same jako si rozdelit na:
            //string text = Console.ReadLine();
            //int.Parse(text);

            //Console.WriteLine("Zadej cislo 2");
            //cislo2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Zadej cislo 3");

            //bool jdeOCislo = false;

            //while (jdeOCislo == false)
            //{

            //    if (int.TryParse(Console.ReadLine(), out cislo3) == false)
            //    {
            //        Console.WriteLine("Zadana spatna hodnota, nejde o cislo!");
            //    }
            //    else
            //    {
            //        jdeOCislo = true;
            //    }

            //}
            //kdyz JdeOCislo bude True (ANO) pak kod pokracuje zde, jinak se opakuje ve smycce
            //double prumer = VypocetPrumeru(cislo1, cislo2, cislo3);
            //int max = GetMaxValue(cislo1, cislo2, cislo3);
            //Console.WriteLine($"Prumer cisel je {prumer}");
            //Console.WriteLine($"Maximum cisel je {max}");
            //NapisCislo1();

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