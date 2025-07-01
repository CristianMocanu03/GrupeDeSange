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
             while (valoareIntrodusa != "C")
            {
 Console.WriteLine("Introdu grupa de sange pe care o ai pentru a va afisa posibilele genotipuri! Cat si grupa parintilor tai! \r\n Grupele de sange sunt A,B,AB sau 0\r\n");
               
           

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
                { Console.WriteLine($"Genotipul dumneavoastra probabil este {genotip[0, 1] + genotip[1, 0]} sau {genotip[1, 0] + genotip[0, 3]} \r\n  grupa parintilor tai poate fi: \r\n ambii {fenotip[0]} \r\n unul {fenotip[0]} si altul {fenotip[1]} \r\n unul{fenotip[0]} si altul {fenotip[3]} \r\n unul{fenotip[1]} si altul {fenotip[3]} "); }
                else if (valoareIntrodusa == genotip[2, 2]) //pentru grupa de sange B
                { Console.WriteLine($"Genotipul dumneavoastra probabil este {genotip[0, 2] + genotip[2, 0]} sau {genotip[2, 0] + genotip[0, 3]} \r\n  grupa parintilor tai poate fi: \r\n ambii {fenotip[1]} \r\n unul {fenotip[1]} si altul {fenotip[3]} \r\n unul{fenotip[0]} si altul {fenotip[1]} "); }
                else if (valoareIntrodusa == genotip[1, 2]) //pentru grupa de sange AB
                { Console.WriteLine($"Genotipul dumneavoastra cu siguranta este {genotip[1, 0] + genotip[0, 2]} \r\n grupa parintilor sigur este: \r\n unul {fenotip[0]} si altul {fenotip[1]} "); }
                else if (valoareIntrodusa == genotip[3, 3]) //pentru grupa de sange 0
                { Console.WriteLine($"Genotipul dumneavoastra cu siguranta este {genotip[3, 0] + genotip[0, 3]} \r\n grupa parintilor cu siguranta consta in macar unu sa aiba grupa {fenotip[3]} "); }
            }
           




























        }

    }
}
