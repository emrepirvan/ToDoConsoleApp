using System;

namespace ToDoConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ToDoList._cards.Add(new Card("TodoApp", "Patika.dev Todo App yapılacak", "Emre Pirvan", "XL"));
            ToDoList._cards.Add(new Card("Veri  tabanı", "Veritabanı kodlari düzenlenicek", "Drizzt DoUrden", "L" , "IN PROCESS"));
            ToDoList._cards.Add(new Card("UI", "UI işlemleri tamamlanıp sunum yapılacak", "Tony Stark", "S","DONE"));
            ToDoList._cards.Add(new Card("TodoApp", "Patika.dev Todo App yapılacak", "Emre Pirvan", "XL"));

            HomePage.Select();
        }
    }
}
