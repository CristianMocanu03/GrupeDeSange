using System.Runtime.ConstrainedExecution;

namespace GrupeDeSange
{
    internal class Program

    {
        static void Main(string[] args)
        {
            Console.WriteLine( "Introdu grupa de sange pe care o ai");
            string grupaIntrodusa = Console.ReadLine();
            if ( grupaIntrodusa ==  "A" )
        {
            Console.WriteLine("Parintii cel mai probabil au grupele: \r\n\r\nA si A\r\n\r\nA si O\r\n\r\nA si AB\r\n\r\nAB si O\r\n\r\nB si A (dacă ambii sunt AO sau BO)");
        }
        else if ( grupaIntrodusa == "B" )
        {
            Console.WriteLine("Parintii cel mai probabil au grupele: \r\n\r\nB si B\r\n\r\nB si O\r\n\r\nB si AB\r\n\r\nA si B (dacă A este AO, iar B este BO)");
        }
        else if( grupaIntrodusa ==  "AB" )
            {
                Console.WriteLine("Parintii cel mai probabil au grupele \r\n\r\nA si B\r\n\r\nAB si A\r\n\r\nAB si B\r\n\r\nAB si AB ") ;

            }
            else if (grupaIntrodusa ==  "0" )
            {
                Console.WriteLine("Parintii cel mai probabil au grupele \r\n\r\nO si O\r\n\r\nA (AO) si O\r\n\r\nB (BO) si O\r\n\r\nA (AO) si B (BO)") ;
            }
        }
        

    }
    
}
