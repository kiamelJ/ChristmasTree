using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Please enter size of christmas tree: ");
            //int input = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine();

            ////SIFFRAN SOM ANGES I "INPUT" STYR HUR MÅNGA GÅNGER
            ////DEN YTTRE LOOPEN SKA KÖRAS, DVS HUR MÅNGA RADER DET
            ////SKA VARA. DEN INRE LOOPEN KÖRS OLIKA GÅNGER BEROENDE PÅ
            ////HUR LÅNGT DEN YTTRE HAR HUNNIT KÖRAS EFTERSOM VI HAR SATT
            ////ETT BEROENDE MELLAN "ROWS" OCH "COL". EFTERSOM ROWS ÄR 1 I 
            ////FÖRSTA YTTRE LOOPEN SÅ KÖRS DEN INRE LOOPEN 1 GÅNG OCH SKRIVER
            ////UT 1 STJÄRNA. NÄR YTTRE LOOPEN ÄR PÅ SITT ANDRA VARV SÅ HAR ROW
            ////VÄRDET 2 OCH DÅ KÖRS INRE LOOPEN 2 GÅNGER OCH SKRIVER UT SITT
            ////INNEHÅLL 2 GÅNGER OSV...

            //for (int rows = 1; rows <= input; rows++)
            //{
            //    for (int col = 1; col <= rows; col++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //Console.ReadLine();

            //******************************************************

            Console.Write("Please enter size of christmas tree: ");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();


        }
    }
}
