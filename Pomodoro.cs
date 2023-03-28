using System;
using System.Threading;

namespace Pomodoro
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
            Start(0);
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("S T U D Y    WITH    P O M O D O R O");
            Console.WriteLine("");
            Console.WriteLine("esc ➭ iniciar.");

            while (Console.ReadKey().Key != ConsoleKey.Escape) ;
        }

        static void Start(int time)
        {
            int pomodoro = 25;

            while (pomodoro != time)
            {
                Console.Clear();

                pomodoro--;
                Console.WriteLine(pomodoro); //1500s são 25m
                Thread.Sleep(60000); // milissegundos
            }
            Console.Clear();

            Console.WriteLine("Pomodoro  finalizado... Dê uma pausa!");

            Thread.Sleep(2000);
        }
    }
}
