using SimplyBooks.Models;

namespace SimplyBooks.Data
{
    public class BookData
    {
        public static List<Book> Books = new()
        {
            new()
            {
                Id = 1,
                Title = "The Yellow Wallpaper",
                Description = "The Yellow Wallpaper by Charlotte Perkins Gilman tells the story of a woman suffering from postpartum depression, who becomes obsessed with the wallpaper in her confinement, revealing the effects of isolation and gender roles.",
                AuthorId = 1,
                Image = "yellowwallpaper.jpg",
                Price = 12.99m,
                Sale = true,
                Uid = "BID001"
            },
            new()
            {
                Id = 2,
                Title = "Herland",
                Description = "Herland by Charlotte Perkins Gilman is a utopian novel about an all-female society, where women live in harmony, without men",
                AuthorId = 1,
                Image = "herland.jpg",
                Price = 10.99m,
                Sale = false,
                Uid = "BID002"
            },
            new()
            {
                Id = 3,
                Title = "Rebecca",
                Description = "Rebecca by Daphne Du Maurier is a Gothic novel about a young woman who marries a wealthy widower, only to find herself overshadowed by the memory of his first wife, Rebecca. As she uncovers dark secrets about Rebecca's life and death, the narrator struggles with jealousy, mystery, and her own sense of identity.",
                AuthorId = 2,
                Image = "rebecca.jpg",
                Price = 9.99m,
                Sale = false,
                Uid = "BID003"
            },
            new()
            {
                Id = 4,
                Title = "My Cousin Rachel",
                Description = "My Cousin Rachel by Daphne Du Maurier is a suspenseful novel about a young man who becomes suspicious of his cousin Rachel after his guardian's mysterious death, while grappling with his growing attraction to her.",
                AuthorId = 2,
                Image = "rachel.jpg",
                Price = 12.99m,
                Sale = true,
                Uid = "BID004"
            },
            new()
            {
                Id = 5,
                Title = "I Who Have Never Known Men",
                Description = "I Who Have Never Known Men by Jacqueline Harpman follows a woman who has spent her life in isolation in an underground bunker. When she is suddenly freed, she discovers a world she never knew, struggling to understand human relationships, gender, and identity in a society she was cut off from.",
                AuthorId = 3,
                Image = "never_known_men.jpg",
                Price = 8.99m,
                Sale = false,
                Uid = "BID005"
            },
            new()
            {
                Id = 6,
                Title = "Orlanda",
                Description = "Orlanda by Jacqueline Harpman tells the story of a woman who mysteriously transforms into a man and experiences life from both genders' perspectives. The novel explores themes of identity, gender, and the fluidity of self through her journey across time and societal roles.",
                AuthorId = 3,
                Image = "orlanda.jpg",
                Price = 11.99m,
                Sale = true,
                Uid = "BID006"
            },
            new()
            {
                Id = 7,
                Title = "Natural Beauty",
                Description = "Natural Beauty by Ling Ling Huang is a novel that follows a Chinese-American woman navigating the complexities of beauty standards, cultural identity, and self-acceptance.",
                AuthorId = 4,
                Image = "beauty.jpg",
                Price = 14.99m,
                Sale = false,
                Uid = "BID007"
            },
            new()
            {
                Id = 8,
                Title = "Immaculate Conception",
                Description = "Immaculate Conception by Ling Ling Huang is a novel about a young woman grappling with her sense of identity, exploring themes of family, faith, and cultural expectations. As she navigates personal challenges, she confronts the complexities of her heritage and the search for meaning in her life.",
                AuthorId = 4,
                Image = "conception.jpg",
                Price = 15.99m,
                Sale = true,
                Uid = "BID008"
            },
            new()
            {
                Id = 9,
                Title = "The Fifth Season",
                Description = "The Fifth Season by N.K. Jemisin is a science fiction novel set in a world plagued by constant seismic activity. The story follows three women with the power to control earth movements as they navigate a society on the brink of collapse, exploring themes of survival, power, and the impact of oppression.",
                AuthorId = 5,
                Image = "fifth_season.jpg",
                Price = 17.99m,
                Sale = true,
                Uid = "BID009"
            },
            new()
            {
                Id = 10,
                Title = "The City We Became",
                Description = "The City We Became by N.K. Jemisin is a fantasy novel where New York City’s boroughs come to life as human avatars. As a mysterious force threatens the city, these avatars must unite to protect their home. The novel explores themes of identity, power, and the complexities of urban life.",
                AuthorId = 5,
                Image = "city_we_became.jpg",
                Price = 12.49m,
                Sale = false,
                Uid = "BID010"
            }
        };
    }
}
