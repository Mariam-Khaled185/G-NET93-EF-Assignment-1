using EF_1.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace EF_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using DbContextBooks dbContextBooks = new DbContextBooks();

            dbContextBooks.Database.MigrateAsync();
        }
    }
}
