using NavigationLesson.DataAccess;
using NavigationLesson.Models;
using System;
using System.Linq;

namespace NavigationLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var context = new LibraryContext())
            {
                /*var author = new Author
                {
                    FullName = "А.С.Пушкин"
                };

                var book = new Book()
                {
                    Title = "Капитанская дочка",
                    Author = author
                };

                context.Add(book);
                context.SaveChanges();*/
                var result = context.Books.ToList();
            }
        }
    }
}
