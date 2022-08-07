using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiTool
{
    class MiniGame
    {
        public static void Game()
        {
            Random ObjR = new Random();

            int NumRandom;

            NumRandom = ObjR.Next(0, 100);

            int intentos = 10;
            int usuarioInsert;
            
            
            
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                string a = @" ______                      ______ __  __ __     __ 
  / __/ /____ _  _____ ___    / ___(_) /_/ // /_ __/ / 
 _\ \/ __/ -_) |/ / -_) _ \  / (_ / / __/ _  / // / _ \
/___/\__/\__/|___/\__/_//_/  \___/_/\__/_//_/\_,_/_.__/
                                                       ";
                Console.WriteLine(a);
                Console.WriteLine("Adivina el numero aleatorio del 1 al 100");
                string rs;
            Console.WriteLine("¿Start Game? (Y/n)");
                rs = Console.ReadLine();
             if(rs == "Y" || rs == "y")
             {
                do
                {


                    Console.WriteLine($"Tus intentos: {intentos}");


                    usuarioInsert = int.Parse(Console.ReadLine());

                    if (usuarioInsert < NumRandom && intentos > 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Estas Abajo del numero");
                        intentos--;
                    }
                    if (usuarioInsert > NumRandom && intentos > 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Estas arriba del numero");
                        intentos--;
                    }
                    else if (intentos < 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ya no tienes mas intentos perdiste");
                    }
                    Console.WriteLine("Presiona una tecla y enter para Limpiar");
                    string o;
                    o = Console.ReadLine();
                    Console.Clear();

                } while (usuarioInsert != NumRandom);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Felicidades Ganaste Con {intentos} intentos");
             }
            else
            {
                Program.Main();
                
            }

            Console.ReadKey();
        }
    }
}
