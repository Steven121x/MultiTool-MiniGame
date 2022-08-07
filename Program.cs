using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiTool
{
    class Program
    {
       public static void Main()
       {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            string e = @" ____ ____ ____ ____ ____ ____ _________ ____ ____ ____ ____ ____ ____ 
||S |||t |||e |||v |||e |||n |||       |||G |||i |||t |||H |||u |||b ||
||__|||__|||__|||__|||__|||__|||_______|||__|||__|||__|||__|||__|||__||
|/__\|/__\|/__\|/__\|/__\|/__\|/_______\|/__\|/__\|/__\|/__\|/__\|/__\|";
           

            Console.WriteLine(e);
            Console.WriteLine("||                                        ");
            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine("(1) MiniGame");
            Console.WriteLine("(2) MatematicasTool");
            Console.WriteLine("(3) Optimizadores");
            Console.WriteLine("(4) Salir del programa");

            int respuesta = int.Parse(Console.ReadLine());
            
            int[] Restp = new int[4];

            Restp[0] = 1;
            Restp[1] = 2;
            Restp[2] = 3;
            Restp[3] = 4;

            if (respuesta == Restp[0])
            {
                MiniGame.Game();
                Console.Clear();
            }
            if (respuesta == Restp[1])
            {
                MatematicasTool.Matematicas();
                Console.Clear();
            }
            if (respuesta == Restp[2])
            {
                Optimizador.Optimizad0r();
                
            }
            if(respuesta == Restp[3])
            {
                Environment.Exit(0);
            }

            Console.ReadKey();
        }
    }
}
