using System.ComponentModel.Design;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;

namespace GrupeDeSange
{
    internal class Program

    {
        static void Main(string[] args)
        {
            var valoareIntrodusa = string.Empty;
         
            while ( valoareIntrodusa != "COPIL"  )


            {
               
                Console.WriteLine(" Introdu cuvantul COPIL daca vrei sa aflii posibila grupa a copilului \r\n SAU \r\n Introdu direct grupa dumneavoastra de sange pentru a afla posibilele grupe a parintilor \r\n Grupele de sange sunt A,B,AB sau 0\r\n");



                string[,] genotip;
                genotip = new string[,]   {    { "0", "La", "Lb", "l" },
                                           { "La", "A", "AB", "A"},
                                           { "Lb", "AB", "B", "B"},
                                           { "l", "A", "B", "0"},
                                          };
                string[] fenotip;
                fenotip = new string[] { " Grupa A", "Grupa B", "Grupa AB ", "Grupa 0" };

                ;

                valoareIntrodusa = Console.ReadLine();
                if (valoareIntrodusa == genotip[1, 1]) // pentru grupa de sange A
                    Console.WriteLine($"Genotipul dumneavoastra probabil este {genotip[0, 1] + genotip[1, 0]} sau {genotip[1, 0] + genotip[0, 3]} \r\n  grupa parintilor tai poate fi: \r\n ambii {fenotip[0]} \r\n unul {fenotip[0]} si altul {fenotip[1]} \r\n unul{fenotip[0]} si altul {fenotip[3]} \r\n unul{fenotip[1]} si altul {fenotip[3]} ");
                else if (valoareIntrodusa == genotip[2, 2]) //pentru grupa de sange B
                    Console.WriteLine($"Genotipul dumneavoastra probabil este {genotip[0, 2] + genotip[2, 0]} sau {genotip[2, 0] + genotip[0, 3]} \r\n  grupa parintilor tai poate fi: \r\n ambii {fenotip[1]} \r\n unul {fenotip[1]} si altul {fenotip[3]} \r\n unul{fenotip[0]} si altul {fenotip[1]} ");
                else if (valoareIntrodusa == genotip[1, 2]) //pentru grupa de sange AB
                    Console.WriteLine($"Genotipul dumneavoastra cu siguranta este {genotip[1, 0] + genotip[0, 2]} \r\n grupa parintilor sigur este: \r\n unul {fenotip[0]} si altul {fenotip[1]} ");
                else if (valoareIntrodusa == genotip[3, 3]) //pentru grupa de sange 0
                    Console.WriteLine($"Genotipul dumneavoastra cu siguranta este {genotip[3, 0] + genotip[0, 3]} \r\n grupa parintilor cu siguranta consta in macar unu sa aiba grupa {fenotip[3]} ");
            }



            while ( valoareIntrodusa == "COPIL" )
            {
                Console.WriteLine("Introdu grupele de sange pe care le aveti pentru a va afisa posibilitatile grupei copilului! \r\n combinatiile de grupe sunt sub forba AB, AA, A0, 0\r\n");



                string[,] genotip;
                genotip = new string[,]   {    { "0", "La", "Lb", "l" },
                                           { "La", "A", "AB", "A"},
                                           { "Lb", "AB", "B", "B"},
                                           { "l", "A", "B", "0"},
                                          };
                string[] fenotip;
                fenotip = new string[] { " Grupa A", "Grupa B", "Grupa AB ", "Grupa 0" };
                valoareIntrodusa = Console.ReadLine();
                if (valoareIntrodusa == genotip[1, 1] + genotip[2, 2]) // pentru grupele de sange A si B
                    Console.WriteLine($" Grupa copiilor tai poate fi: \r\n 1. {fenotip[3]} \r\n 2. {fenotip[0]} \r\n 3. {fenotip[1]} \r\n 4. {fenotip[2]}" );
                else if (valoareIntrodusa == genotip[1, 1] + genotip[1, 1]) //pentru grupele de sange A si A
                    Console.WriteLine($" Grupa copiilor tai poate fi: \r\n 1. {fenotip[0]} \r\n 2. {fenotip[3]} ");
                else if (valoareIntrodusa == genotip[2, 2] + genotip[3, 3]) //pentru grupele de sange B 0
                    Console.WriteLine($" Grupa copiilor sigur este: {fenotip[1]} ");
                else if (valoareIntrodusa == genotip[3, 3] + genotip[3, 3]) //pentru grupa de sange 0
                    Console.WriteLine($" Grupa copiilor cu siguranta este {fenotip[3]} ");
            }

































        }

       }
    }

