using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoConsoleApp
{
    public class Card
    {
        public string Baslik { get; set; }
        public string Icerik { get; set; }
        public string AtananKisi { get; set; }
        public string Buyukluk { get; set; }
        public string BulunduguLine { get; set; }
        public Card(string baslik, string icerik, string atananKisi, string buyukluk, string bulunduguLine = "TODO")
        {
            Baslik = baslik;
            Icerik = icerik;
            AtananKisi = atananKisi;
            Buyukluk = buyukluk;
            BulunduguLine = bulunduguLine;
        }
    }
}
