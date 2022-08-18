using InMemoryWebApi.Models;
using InMemoryWebApi.Utils;
using System.Collections.Generic;

namespace InMemoryWebApi.Context
{
	public class DatabaseContextSeed
	{
		private static List<BookEntity> _books = new();
		private static List<Album> _albums = new();
		private static List<Comment> _comments = new();
		private static List<Photo> _photos = new();
		private static List<Todo> _todos = new();
		private static List<User> _users = new();

		public static void Seed(DatabaseContext context)
		{
			context.Database.EnsureCreated();
			//context.Database.EnsureDeleted();

			foreach (var album in JsonReaderUtils.ReadJson<Album>("albums"))
			{
				_albums.Add(album);
			}

			foreach (var book in JsonReaderUtils.ReadJson<BookEntity>("books"))
			{
				_books.Add(book);
			}

			foreach (var comment in JsonReaderUtils.ReadJson<Comment>("comments"))
			{
				_comments.Add(comment);
			}

			foreach (var item in JsonReaderUtils.ReadJson<Photo>("photos"))
			{
				_photos.Add(item);
			}

			foreach (var item in JsonReaderUtils.ReadJson<Todo>("todos"))
			{
				_todos.Add(item);
			}

			foreach (var item in JsonReaderUtils.ReadJson<User>("users"))
			{
				_users.Add(item);
			}

			//for (int i = 1; i < 50; i++)
			//{
			//	_list.Add(new Book { Id = i, Name = "Book example " + i });
			//}

			context.Albums.AddRange(_albums);
			context.BookEntities.AddRange(_books);
			context.Comments.AddRange(_comments);
			context.Photos.AddRange(_photos);
			context.Todos.AddRange(_todos);
			context.Users.AddRange(_users);
			context.SaveChangesAsync();
		}
	}
}