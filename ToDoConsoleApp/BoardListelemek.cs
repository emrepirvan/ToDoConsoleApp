using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoConsoleApp
{
    public static class BoardListelemek
    {
        public static void Goster()
        {
            foreach (var item in ToDoList._cards)
            {
                if (item.BulunduguLine.ToLower() == "TODO")
                {
                    Console.WriteLine("todo line ---------------");
                }
                else if (item.BulunduguLine.ToLower() == "in process")
                {
                    Console.WriteLine("INPROCESS LINE ---------------");
                }
                else if (item.BulunduguLine.ToLower() == "done")
                {
                    Console.WriteLine("done  LINE ---------------");
                }
                Console.WriteLine($"Başlık      :{item.Baslik}\nİçerik      :{item.Icerik}\nAtanan Kişi :{item.AtananKisi}\nBüyüklük    :{item.Buyukluk}\n-");
            }
        }
    }
}
