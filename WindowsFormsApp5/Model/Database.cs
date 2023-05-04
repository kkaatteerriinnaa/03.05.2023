using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5.Model
{
    class Database
    {
        List<Book> books = new List<Book>(); //1. реализовать через файл!!!

        public Database()
        {
            books.Add(new Book("CLR via C#","Jefry Richter"));
            books.Add(new Book("Эмоциональный интеллект", "Дэниел Гоулман"));
            books.Add(new Book("С++", "Бьярне Страуструп"));
            books.Add(new Book("ТРИЗ", "Марк Меерович"));
        }
        public Book Find(string bookName)
        {
           foreach(Book f in books)
            {
                if(f.Name==bookName)
                {                   
                    return f;
                }
            }
            return null;
        }

    }
}
 /*
  1. БД - это текстовый документ - без массива!!
  2. Поиск по имени, поиск по автору (выбор через радиокнопку), регистронезависимость!
    (если введенная строка присутствует в названии книги, в любой позиции, вывести все книги!)  
  */