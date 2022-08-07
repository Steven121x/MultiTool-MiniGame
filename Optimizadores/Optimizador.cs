using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiTool
{
    class Optimizador
    {
        //Actualizar los link de descargas 
        //Codigo de descargar y ejecutar archivos 
        public static void Optimizad0r()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            string a = @" ______                      ______ __  __ __     __ 
  / __/ /____ _  _____ ___    / ___(_) /_/ // /_ __/ / 
 _\ \/ __/ -_) |/ / -_) _ \  / (_ / / __/ _  / // / _ \
/___/\__/\__/|___/\__/_//_/  \___/_/\__/_//_/\_,_/_.__/
                                                       ";
            Console.WriteLine("Tool for optimizer you pc");
            Console.WriteLine("¿Start Tool? (Y/n)");
            string t;
            t = Console.ReadLine();
            if (t == "Y" || t == "y")
            {
                Console.WriteLine(a);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("(1) Windows Fast");
                Console.WriteLine("(2) Wifi Fast");
                Console.WriteLine("(3) Memory fast");
                Console.WriteLine("(4) Delete Temp Files");
                Console.WriteLine("(5) Time of Responsive");

                int y;
                y = int.Parse(Console.ReadLine());


                switch (y)
                {

                    case 1:
                        FilesLib.WindowFast();
                        break;

                    case 2:
                        FilesLib.Wifi();
                        break;

                    case 3:
                        FilesLib.memory();
                        break;

                    case 4:
                        FilesLib.temp();
                        break;

                    case 5:
                        FilesLib.respuesta();
                        break;

                }
            }
            else
            {
                Program.Main();
            }
               

        }
    }

    class FilesLib
    {
        public static void Wifi()
        {
            WebClient dw = new WebClient();
            dw.DownloadFile("https://cdn.discordapp.com/attachments/1005818729910775889/1005820336568287303/Desativar_Limitacao_de_Rede.reg", "C:/Desativar_Limitacao_de_Rede.reg");
            if (File.Exists("C:/Desativar_Limitacao_de_Rede.reg"))
            {
               Process.Start("C:/Desativar_Limitacao_de_Rede.reg");
                Thread.Sleep(2000);
                if(File.Exists("C:/Desativar_Limitacao_de_Rede.reg"))
                {
                    File.Delete("C:/Desativar_Limitacao_de_Rede.reg");
                }

                Console.WriteLine("Se ha Optimizado con Exito !");
            }
        }
        public static void WindowFast()
        {
            WebClient dw = new WebClient();
            dw.DownloadFile("https://cdn.discordapp.com/attachments/1005818729910775889/1005820336912203858/Execute_Para_Deixar_o_Windows_Mais_Rapido.reg", "C:/Execute_Para_Deixar_o_Windows_Mais_Rapido.reg");
            if (File.Exists("C:/Execute_Para_Deixar_o_Windows_Mais_Rapido.reg"))
            {
                Process.Start("C:/Execute_Para_Deixar_o_Windows_Mais_Rapido.reg");
                Thread.Sleep(2000);
                if (File.Exists("C:/Execute_Para_Deixar_o_Windows_Mais_Rapido.reg"))
                {
                    File.Delete("C:/Execute_Para_Deixar_o_Windows_Mais_Rapido.reg");
                }

                Console.WriteLine("Se ha Optimizado con Exito !");
            }
        }
        public static void memory()
        {
            try
            {
                //optimizacion
                WebClient d4ownload = new WebClient();
                string address = "cdn.discordapp.com/attachments/1005818729910775889/1005820337646219294/Otimizador_de_memoria.bat"; //Link para baixar a regedit
                string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Resources); //Directorio donde sera puesto
                string fileName = "Otimizador_de_memoria.bat"; //formato de su archivo
                d4ownload.DownloadFile(address, desktop + "\\" + fileName);

                ProcessStartInfo psi = new ProcessStartInfo //funcion para ejecutar el archivo
                {
                    FileName = @"C:\Windows\Resources\Otimizador_de_memoria.bat",
                    UseShellExecute = true
                };

                Process.Start(psi);
                Thread.Sleep(2600); //Tiempo para que despues de ser ejecutada ser eliminada
                File.Delete(@"C:\Windows\Resources\Otimizador_de_memoria.bat"); 
            }
            catch (Exception) 
            {

                Console.WriteLine("ERROR !");

            }
        }
        public static void temp()
        {
            WebClient dw = new WebClient();
            dw.DownloadFile("https://cdn.discordapp.com/attachments/1005818729910775889/1005820336207568896/Limpa_temp.bat", "C:/Limpa_temp.bat");
            if (File.Exists("C:/Limpa_temp.bat"))
            {
                Process.Start("C:/Limpa_temp.bat");
                Thread.Sleep(2000);
                if (File.Exists("C:/Limpa_temp.bat"))
                {
                    File.Delete("C:/Limpa_temp.bat");
                }

                Console.WriteLine("Se ha Optimizado con Exito !");
            }
        }
        public static void respuesta()
        {
            WebClient dw = new WebClient();
            dw.DownloadFile("https://cdn.discordapp.com/attachments/1005818729910775889/1005820337272918046/Tempo_de_resposta.reg", "C:/Tempo_de_resposta.reg");
            if (File.Exists("C:/Tempo_de_resposta.reg"))
            {
                Process.Start("C:/Tempo_de_resposta.reg");
                Thread.Sleep(2000);
                if (File.Exists("C:/Tempo_de_resposta.reg"))
                {
                    File.Delete("C:/Tempo_de_resposta.reg");
                }

                Console.WriteLine("Se ha Optimizado con Exito !");
            }
        }
    }

}
