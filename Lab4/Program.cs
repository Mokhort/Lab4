using System;
using System.Threading;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        public static int num = 1;
        async static Task Main(string[] args)
        {

            Task sum_task = SumAsync();
            Task mul_task = MulAsync();
            Task menu_task = MenuAsync();
            await sum_task;
            await mul_task;
            await menu_task;
        }
        static async Task SumAsync()
        {
                await Task.Run(() => Sum());
        }
        static async Task MulAsync()
        {
                await Task.Run(() => Mul());
        }
        static async Task MenuAsync()
        {
            await Task.Run(() => Menu());
        }

        static void Sum() 
        {
            while (true)
            {
                num += 2;
                Thread.Sleep(2000);
            }
        }

        //static async Task<int> Mul()
        static void Mul()
        {
            while (true)
            {
                num *= 3;
                Thread.Sleep(3000);
            }
        }

        //static async Task<int> Menu()
        static void Menu()
        {
            string cmd;
            while (true)
            {
                Console.WriteLine("Enter STOP/SHOW:");
                cmd = Console.ReadLine();
                if (cmd == "STOP" || cmd == "stop")
                {
                    Console.WriteLine("Closing programm...");
                    Environment.Exit(0);
                }
                else if (cmd == "SHOW" || cmd == "show")
                {
                    Console.WriteLine("Showing status...");
                    Console.WriteLine($"Num = {num}");
                }
                else
                {
                    Console.WriteLine("Invalid command");
                }
            }
        }
    }
}
