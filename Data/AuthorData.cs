using SimplyBooks.Models;

namespace SimplyBooks.Data
{
    public class AuthorData
    {
        public static List<Author> Authors = new()
        {
            new()
            {
                Id = 1,
                FirstName = "Charlotte",
                LastName = "Perkins Gilman",
                Email = "charlotte.perkins@example.com",
                Image = "charlotte.jpg",
                Favorite = true,
                Uid = "UID001"
            },
            new()
            {
                Id = 2,
                FirstName = "Daphne",
                LastName = "du Maurier",
                Email = "daphne.du.maurier@example.com",
                Image = "dumarier.jpg",
                Favorite = true,
                Uid = "UID002"
            },
            new()
            {
                Id = 3,
                FirstName = "Jacqueline",
                LastName = "Harpman",
                Email = "jacqueline.harpman@example.com",
                Image = "harpman.jpg",
                Favorite = false,
                Uid = "UID003"
            },
            new()
            {
                Id = 4,
                FirstName = "Ling Ling",
                LastName = "Huang",
                Email = "ling.ling.huang@example.com",
                Image = "huang.jpg",
                Favorite = false,
                Uid = "UID004"
            },
            new()
            {
                Id = 5,
                FirstName = "N.K.",
                LastName = "Jemisin",
                Email = "nk.jemisin@example.com",
                Image = "jemisin.jpg",
                Favorite = true,
                Uid = "UID005"
            }

        };

    }
}
