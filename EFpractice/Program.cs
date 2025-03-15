using Microsoft.EntityFrameworkCore;

namespace EFpractice
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            var dictionary = new Dictionary<string, Action>()
            {
                {"add",Add},
                {"show",Show},
                //{"update",Update },
                //{"delete",Delete }
            };
            while (true)
            {
                Console.WriteLine("Insert command");
                var command=Console.ReadLine().ToLower();

            }
        }
        public static void Add()
        {
            var dbContext = new AppDbContext();
            Console.WriteLine("Insert name of the team: ");
            var name=Console.ReadLine();
            var student = new Team()
            {
                Name = name
            };

            dbContext.Teams.Add(student);
            dbContext.SaveChanges();
        }

        public static void Show()
        {
            var dbContext = new AppDbContext();
            var teams=dbContext.Teams;

            foreach(var item in teams)
            {
                Console.WriteLine($"{item.Id}. {item.Name}");
            }
        }

        
    }
}
