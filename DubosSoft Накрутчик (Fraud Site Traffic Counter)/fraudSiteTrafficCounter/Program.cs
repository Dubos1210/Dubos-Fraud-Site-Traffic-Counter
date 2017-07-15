using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net;

namespace vkmessenger
{
    class Program
    {
        static void getrequest(string url)
        {
            using (var webClient = new WebClient())
            {
                var response = webClient.DownloadString(url);
            }
        }
        static void Main(string[] args)
        {
            int cycles, delay;
            string url;
            Console.WriteLine(@" ====================================================== ");
            Console.WriteLine(@"||           _               _                        ||");
            Console.WriteLine(@"|| |    |   | \     |_   _  |_                        ||");
            Console.WriteLine(@"|| |    |   |_/ |_| |_| |_|  _|  _____                ||");
            Console.WriteLine(@"|| |----|    /\   | /  | \ \   /   |   |  | |  /| | / ||");
            Console.WriteLine(@"|| |    |   /--\  |-   |_/  \ /    |   \__| | / | |-  ||");
            Console.WriteLine(@"|| |    |  /    \ | \  |     /     |      | |/  | | \ ||");
            Console.WriteLine(@"||                                                    ||");
            Console.WriteLine(@" ====================================================== ");
            Console.WriteLine("Накртутчик для счетчиков песещаемости сайтов Dubos");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Введите URL (адрес) сайта (НЕ ЗАБЫВАЙТЕ В НАЧАЛЕ ПУТИ УКАЗАТЬ http://)");
            url = Console.ReadLine();
            Console.WriteLine("Введите количество запросов к сайту");
            cycles = Convert.ToInt32(Console.ReadLine());
            cycles = cycles + 1;
            Console.WriteLine("Введите задержку между запросами в миллисекундах (1000 мсек = 1 сек)");
            delay = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < cycles; i++)
            {
                getrequest(url);
                Console.WriteLine(i+" запрос отправлен");
                Thread.Sleep(delay);
            }
            Console.WriteLine("Готово. Нажмите любую клавишу для выхода");
            Console.ReadKey();
        }
    }
}
