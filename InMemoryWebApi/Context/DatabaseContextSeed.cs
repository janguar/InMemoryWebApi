using InMemoryWebApi.Models;
using System.Collections.Generic;

namespace InMemoryWebApi.Context
{
    public class DatabaseContextSeed
    {

        private static List<Book> _list = new();
        public static void Seed(DatabaseContext context)
        {
            context.Database.EnsureCreated();
            //context.Database.EnsureDeleted();

            for (int i = 1; i < 50; i++)
            {
                _list.Add(new Book { Id = i, Name = "Book example " + i });

            }

            context.Books.AddRange(_list);
            context.SaveChangesAsync();
        }
    }
}
