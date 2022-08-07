using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiTool
{
    class MatematicasTool
    {
        public static void Matematicas()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            string a = @" ______                      ______ __  __ __     __ 
  / __/ /____ _  _____ ___    / ___(_) /_/ // /_ __/ / 
 _\ \/ __/ -_) |/ / -_) _ \  / (_ / / __/ _  / // / _ \
/___/\__/\__/|___/\__/_//_/  \___/_/\__/_//_/\_,_/_.__/
                                                       ";
            Console.WriteLine(a);

            Console.WriteLine("Sistema de Matematicas");
            Console.WriteLine("¿Start Tool? (Y/n)");
            string t;
            t = Console.ReadLine();
            if(t == "Y" || t == "y")
            {
                Console.WriteLine("(1) Suma");
                Console.WriteLine("(2) Resta");
                Console.WriteLine("(3) Multiplicacion");
                Console.WriteLine("(4) Dividir");
                Console.WriteLine("(5) RaizCuadrada");
                Console.WriteLine("(6) Pow | Potencia");

                int respuesta = int.Parse(Console.ReadLine());

                

                if (respuesta == 1)
                {
                    Console.Clear();
                    suma.Suma();
                   
                }
                if (respuesta == 2)
                {
                    Console.Clear();
                    resta.Resta();
                }
                if (respuesta == 3)
                {
                    Console.Clear();
                    multiplicacion.Multiplicacion();

                }
                if (respuesta == 4)
                {
                    Console.Clear();
                    Dividir.Div1dir();
                }
                if (respuesta == 5)
                {
                    Console.Clear();
                    Raiz.Ra1z();
                }
                if (respuesta == 6)
                {
                    Console.Clear();
                    pow.Pow();
                }
            }
            else
            {
                Program.Main();
            }

            
        }
    }

    class suma
    {
       public static void Suma()
       {
            
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            string a = @" ______                      ______ __  __ __     __ 
  / __/ /____ _  _____ ___    / ___(_) /_/ // /_ __/ / 
 _\ \/ __/ -_) |/ / -_) _ \  / (_ / / __/ _  / // / _ \
/___/\__/\__/|___/\__/_//_/  \___/_/\__/_//_/\_,_/_.__/
                                                       ";
            Console.WriteLine(a);

            Console.WriteLine("Bienvenido a Suma");
            Console.WriteLine("Intoduce tu primer numero");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Intoduce tu Segundo numero");
            int num2 = int.Parse(Console.ReadLine());

            MatematicasLib math = new MatematicasLib();

            Console.WriteLine("Tu resultado es: " + math.suma(num1, num2));
            Console.ReadKey();
            Program.Main();

        }





    }

    class resta
    {
       public static void Resta()
       {
           

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            string a = @" ______                      ______ __  __ __     __ 
  / __/ /____ _  _____ ___    / ___(_) /_/ // /_ __/ / 
 _\ \/ __/ -_) |/ / -_) _ \  / (_ / / __/ _  / // / _ \
/___/\__/\__/|___/\__/_//_/  \___/_/\__/_//_/\_,_/_.__/
                                                       ";
            Console.WriteLine(a);


            Console.WriteLine("Bienvenido a Resta");
            Console.WriteLine("Intoduce tu primer numero");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Intoduce tu Segundo numero");
            int num2 = int.Parse(Console.ReadLine());

            MatematicasLib math = new MatematicasLib();

            Console.WriteLine("Tu resultado es: " + math.resta(num1, num2));
            Console.ReadKey();
            Program.Main();


        }

    }

    class multiplicacion
    {
       public static void Multiplicacion()
        {
          

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            string a = @" ______                      ______ __  __ __     __ 
  / __/ /____ _  _____ ___    / ___(_) /_/ // /_ __/ / 
 _\ \/ __/ -_) |/ / -_) _ \  / (_ / / __/ _  / // / _ \
/___/\__/\__/|___/\__/_//_/  \___/_/\__/_//_/\_,_/_.__/
                                                       ";
            Console.WriteLine(a);

            MatematicasLib math = new MatematicasLib();
            Console.WriteLine("Bienvenido a Multiplicacion");
            Console.WriteLine("Intoduce tu primer numero");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Intoduce tu Segundo numero");
            int num2 = int.Parse(Console.ReadLine());

            

            Console.WriteLine($"Tu resultado es: {math.multiplica(num1, num2)}");
            Console.ReadKey();
            Program.Main();
        }

    }

    class Dividir
    {
        public static void Div1dir()
        {
          

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            string a = @" ______                      ______ __  __ __     __ 
  / __/ /____ _  _____ ___    / ___(_) /_/ // /_ __/ / 
 _\ \/ __/ -_) |/ / -_) _ \  / (_ / / __/ _  / // / _ \
/___/\__/\__/|___/\__/_//_/  \___/_/\__/_//_/\_,_/_.__/
                                                       ";
            Console.WriteLine(a);


            Console.WriteLine("Bienvenido a Divide");
            Console.WriteLine("Intoduce tu primer numero");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Intoduce tu Segundo numero");
            int num2 = int.Parse(Console.ReadLine());

            MatematicasLib math = new MatematicasLib();

            Console.WriteLine("Tu resultado es: " + math.divide(num1, num2));
            Console.ReadKey();
            Program.Main();
        }

    }

    class pow
    {
      
       public static void Pow()
       {
            

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            string a = @" ______                      ______ __  __ __     __ 
  / __/ /____ _  _____ ___    / ___(_) /_/ // /_ __/ / 
 _\ \/ __/ -_) |/ / -_) _ \  / (_ / / __/ _  / // / _ \
/___/\__/\__/|___/\__/_//_/  \___/_/\__/_//_/\_,_/_.__/
                                                       ";

            Console.WriteLine(a);


            Console.WriteLine("Bienvenido a Pow/Potencia");
            Console.WriteLine("Intoduce tu primer numero");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Intoduce tu Segundo numero");
            int num2 = int.Parse(Console.ReadLine());

            MatematicasLib math = new MatematicasLib();

            Console.WriteLine("Tu resultado es: " + math.Pow0(num1, num2));
            Console.ReadKey();
            Program.Main();
        }
    }

   class Raiz
   {
       public static void Ra1z()
       {
           

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            string a = @" ______                      ______ __  __ __     __ 
  / __/ /____ _  _____ ___    / ___(_) /_/ // /_ __/ / 
 _\ \/ __/ -_) |/ / -_) _ \  / (_ / / __/ _  / // / _ \
/___/\__/\__/|___/\__/_//_/  \___/_/\__/_//_/\_,_/_.__/
                                                       ";

            Console.WriteLine(a);


            Console.WriteLine("Bienvenido a Raiz Cuadrada");
            Console.WriteLine("Intoduce tu numero");
            int num1 = int.Parse(Console.ReadLine());
          

            MatematicasLib math = new MatematicasLib();

            Console.WriteLine("Tu resultado es:" + math.RaizCuadrada(num1));
            Console.ReadKey();
            Program.Main();
       }
   }
}
