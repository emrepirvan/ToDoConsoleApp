using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoConsoleApp
{
    public static class DisplayCards
    { 
        public static void ToDo()
        {
            int sayac = 0;
            Console.WriteLine(" TODO Line\n" +
                " * ***********************");
            foreach (var item in ToDoList._cards)
            {

                if (item.BulunduguLine.ToLower() == "todo")
                {
                    sayac++;
                    Console.WriteLine($"Başlık      :{item.Baslik}\nİçerik      :{item.Icerik}\nAtanan Kişi :{item.AtananKisi}\nBüyüklük    :{item.Buyukluk}\n");
                }
            }
            if (sayac == 0)
            {
                Console.WriteLine("~ BOŞ ~");
            }
            Console.WriteLine("\n");
        }
        public static void InProgress()
        {
            int sayac = 0;
            Console.WriteLine(" IN PROGRESS Line\n" +
                " * ***********************");
            foreach (var item in ToDoList._cards)
            {

                if (item.BulunduguLine.ToLower() == "in progress")
                {
                    sayac++;
                    Console.WriteLine($"Başlık      :{item.Baslik}\nİçerik      :{item.Icerik}\nAtanan Kişi :{item.AtananKisi}\nBüyüklük    :{item.Buyukluk}\n");
                }
            }
            if (sayac == 0)
            {
                Console.WriteLine("~ BOŞ ~");
            }
            Console.WriteLine("\n");
        }
        public static void Done()
        {
            int sayac = 0;
            Console.WriteLine(" DONE Line\n" +
                " * ***********************");
            foreach (var item in ToDoList._cards)
            {

                if (item.BulunduguLine.ToLower() == "done")
                {
                    sayac++;
                    Console.WriteLine($"Başlık      :{item.Baslik}\nİçerik      :{item.Icerik}\nAtanan Kişi :{item.AtananKisi}\nBüyüklük    :{item.Buyukluk}\n");
                }
            }
            if (sayac == 0)
            {
                Console.WriteLine("~ BOŞ ~");
            }
            Console.WriteLine("\n");
        }
    }
}
