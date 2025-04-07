using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SimplyBooksBE.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Image = table.Column<string>(type: "text", nullable: false),
                    Favorite = table.Column<bool>(type: "boolean", nullable: false),
                    Uid = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    AuthorId = table.Column<int>(type: "integer", nullable: false),
                    Image = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    Sale = table.Column<bool>(type: "boolean", nullable: false),
                    Uid = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Email", "Favorite", "FirstName", "Image", "LastName", "Uid" },
                values: new object[,]
                {
                    { 1, "charlotte.perkins@example.com", true, "Charlotte", "charlotte.jpg", "Perkins Gilman", "UID001" },
                    { 2, "daphne.du.maurier@example.com", true, "Daphne", "dumarier.jpg", "du Maurier", "UID002" },
                    { 3, "jacqueline.harpman@example.com", false, "Jacqueline", "harpman.jpg", "Harpman", "UID003" },
                    { 4, "ling.ling.huang@example.com", false, "Ling Ling", "huang.jpg", "Huang", "UID004" },
                    { 5, "nk.jemisin@example.com", true, "N.K.", "jemisin.jpg", "Jemisin", "UID005" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Image", "Price", "Sale", "Title", "Uid" },
                values: new object[,]
                {
                    { 1, 1, "The Yellow Wallpaper by Charlotte Perkins Gilman tells the story of a woman suffering from postpartum depression, who becomes obsessed with the wallpaper in her confinement, revealing the effects of isolation and gender roles.", "yellowwallpaper.jpg", 12.99m, true, "The Yellow Wallpaper", "BID001" },
                    { 2, 1, "Herland by Charlotte Perkins Gilman is a utopian novel about an all-female society, where women live in harmony, without men", "herland.jpg", 10.99m, false, "Herland", "BID002" },
                    { 3, 2, "Rebecca by Daphne Du Maurier is a Gothic novel about a young woman who marries a wealthy widower, only to find herself overshadowed by the memory of his first wife, Rebecca. As she uncovers dark secrets about Rebecca's life and death, the narrator struggles with jealousy, mystery, and her own sense of identity.", "rebecca.jpg", 9.99m, false, "Rebecca", "BID003" },
                    { 4, 2, "My Cousin Rachel by Daphne Du Maurier is a suspenseful novel about a young man who becomes suspicious of his cousin Rachel after his guardian's mysterious death, while grappling with his growing attraction to her.", "rachel.jpg", 12.99m, true, "My Cousin Rachel", "BID004" },
                    { 5, 3, "I Who Have Never Known Men by Jacqueline Harpman follows a woman who has spent her life in isolation in an underground bunker. When she is suddenly freed, she discovers a world she never knew, struggling to understand human relationships, gender, and identity in a society she was cut off from.", "never_known_men.jpg", 8.99m, false, "I Who Have Never Known Men", "BID005" },
                    { 6, 3, "Orlanda by Jacqueline Harpman tells the story of a woman who mysteriously transforms into a man and experiences life from both genders' perspectives. The novel explores themes of identity, gender, and the fluidity of self through her journey across time and societal roles.", "orlanda.jpg", 11.99m, true, "Orlanda", "BID006" },
                    { 7, 4, "Natural Beauty by Ling Ling Huang is a novel that follows a Chinese-American woman navigating the complexities of beauty standards, cultural identity, and self-acceptance.", "beauty.jpg", 14.99m, false, "Natural Beauty", "BID007" },
                    { 8, 4, "Immaculate Conception by Ling Ling Huang is a novel about a young woman grappling with her sense of identity, exploring themes of family, faith, and cultural expectations. As she navigates personal challenges, she confronts the complexities of her heritage and the search for meaning in her life.", "conception.jpg", 15.99m, true, "Immaculate Conception", "BID008" },
                    { 9, 5, "The Fifth Season by N.K. Jemisin is a science fiction novel set in a world plagued by constant seismic activity. The story follows three women with the power to control earth movements as they navigate a society on the brink of collapse, exploring themes of survival, power, and the impact of oppression.", "fifth_season.jpg", 17.99m, true, "The Fifth Season", "BID009" },
                    { 10, 5, "The City We Became by N.K. Jemisin is a fantasy novel where New York City’s boroughs come to life as human avatars. As a mysterious force threatens the city, these avatars must unite to protect their home. The novel explores themes of identity, power, and the complexities of urban life.", "city_we_became.jpg", 12.49m, false, "The City We Became", "BID010" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorId",
                table: "Books",
                column: "AuthorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Authors");
        }
    }
}
