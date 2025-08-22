using BookStore.Models;

namespace BookStore.Data
{
    public static class FakeData
    {
        public static List<Author> Authors = new()
        {
            new Author { Id = 1, Name = "Sophia Clark", Biography = "Tech researcher specializing in AI and robotics." },
            new Author { Id = 2, Name = "Liam Johnson", Biography = "Environmental activist and writer on sustainability." },
            new Author { Id = 3, Name = "Amira Hassan", Biography = "Historian with focus on Middle Eastern and African civilizations." }
        };

        public static List<Category> Categories = new()
        {
            new Category { Id = 1, Name = "Technology" },
            new Category { Id = 2, Name = "Environment" },
            new Category { Id = 3, Name = "History" }
        };

        public static List<Book> Books = new()
        {
            new Book { Id = 1, Title = "AI Revolution", Description = "Exploring the future of artificial intelligence", AuthorId = 1, CategoryId = 1 },
            new Book { Id = 2, Title = "Green Planet", Description = "A guide to sustainable living and eco-friendly practices", AuthorId = 2, CategoryId = 2 },
            new Book { Id = 3, Title = "History of Civilizations", Description = "From ancient empires to modern societies", AuthorId = 3, CategoryId = 3 }
        };

        static FakeData()
        {
         
            foreach (var book in Books)
            {
                book.Author = Authors.FirstOrDefault(a => a.Id == book.AuthorId);
                book.Category = Categories.FirstOrDefault(c => c.Id == book.CategoryId);
            }

            foreach (var author in Authors)
            {
                author.Books = Books.Where(b => b.AuthorId == author.Id).ToList();
            }

            foreach (var category in Categories)
            {
                category.Books = Books.Where(b => b.CategoryId == category.Id).ToList();
            }
        }
    }
}

