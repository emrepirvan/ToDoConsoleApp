using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoConsoleApp
{
    public class AddCard
    {
        public static void NewCard()
        {
            Console.Write("Başlık Giriniz                                  :\n");
            string baslik = Console.ReadLine();
            Console.Write("İçerik Giriniz                                  :\n");
            string icerik = Console.ReadLine();
            Console.Write("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  :\n");
            Card.buyukluk buyukluk = new Card.buyukluk();
            
            buyukluk = (Card.buyukluk)Convert.ToInt32(Console.ReadLine());
            if (buyukluk is < (Card.buyukluk)1 or > (Card.buyukluk)5)
            {
                Console.Write("Lütfen Geçerli bir büyüklük giriniz Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  :\n");
                buyukluk = (Card.buyukluk)Convert.ToInt32(Console.ReadLine());
            }
            
            Console.Write("Kişi Seçiniz                                    :\n");
            string kisiAdiSoyadi = Console.ReadLine();

            ToDoList._cards.Add(new Card(baslik,icerik,kisiAdiSoyadi,buyukluk));
        }
    }
}
