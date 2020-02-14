using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace BlackSlope.Api.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ReleaseDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 1, "Lorem ipsum dolor sit amet, ut consul soluta persius quo, et eam mundi scribentur, eros invidunt dissentias no eum.", new DateTime(2020, 2, 14, 10, 2, 44, 854, DateTimeKind.Local).AddTicks(3677), "The Shawshank Redemption" },
                    { 28, "Et probo ornatus sententiae cum, in unum urbanitas usu.", new DateTime(2020, 2, 14, 10, 2, 44, 857, DateTimeKind.Local).AddTicks(7994), "Se7en" },
                    { 29, "Velit omittam inciderint te cum, sit at urbanitas reformidans.", new DateTime(2020, 2, 14, 10, 2, 44, 857, DateTimeKind.Local).AddTicks(8062), "Léon: The Professional" },
                    { 30, "Causae tincidunt pro no, ius munere viderer albucius ex.", new DateTime(2020, 2, 14, 10, 2, 44, 857, DateTimeKind.Local).AddTicks(8066), "The Silence of the Lambs" },
                    { 31, "Id detraxit facilisi eleifend mea, mel ex nobis bonorum oporteat, ius oportere evertitur ut.", new DateTime(2020, 2, 14, 10, 2, 44, 857, DateTimeKind.Local).AddTicks(8069), "Star Wars: Episode IV - A New Hope" },
                    { 32, "No discere adolescens mnesarchum eam, quo latine voluptua ei.", new DateTime(2020, 2, 14, 10, 2, 44, 857, DateTimeKind.Local).AddTicks(8072), "It's a Wonderful Life" },
                    { 33, "Ei pro dolorem fierent blandit, te mea viris nihil legimus.", new DateTime(2020, 2, 14, 10, 2, 44, 857, DateTimeKind.Local).AddTicks(8075), "Once Upon a Time ... in Hollywood" },
                    { 34, "Ex duo euismod fastidii, cu euismod splendide signiferumque qui, eu eos doctus virtute.", new DateTime(2020, 2, 14, 10, 2, 44, 857, DateTimeKind.Local).AddTicks(8078), "Spider-Man: Into the Spider-Verse" },
                    { 35, "Eum cu quem integre verterem, has animal fabulas ut.", new DateTime(2020, 2, 14, 10, 2, 44, 857, DateTimeKind.Local).AddTicks(8081), "Avengers: Infinity War" },
                    { 36, "Tacimates definiebas has an.", new DateTime(2020, 2, 14, 10, 2, 44, 857, DateTimeKind.Local).AddTicks(8085), "Whiplash" },
                    { 37, "Nec ut ridens meliore pertinax.", new DateTime(2020, 2, 14, 10, 2, 44, 857, DateTimeKind.Local).AddTicks(8088), "The Intouchables" },
                    { 38, "Mei te graeci essent, dico sapientem cum ea, eum ei graeci alterum.", new DateTime(2020, 2, 14, 10, 2, 44, 857, DateTimeKind.Local).AddTicks(8091), "The Prestige" },
                    { 39, "Elit quando dictas eos ei.", new DateTime(2020, 2, 14, 10, 2, 44, 857, DateTimeKind.Local).AddTicks(8095), "The Departed" },
                    { 40, "Eros tota utinam mei ei, iisque consequuntur te his.", new DateTime(2020, 2, 14, 10, 2, 44, 857, DateTimeKind.Local).AddTicks(8098), "The Pianist" },
                    { 41, "Ne per fugit graece, quando expetendis id sea.", new DateTime(2020, 2, 14, 10, 2, 44, 857, DateTimeKind.Local).AddTicks(8101), "Memento" },
                    { 42, "Duo novum noluisse et, at vel adhuc porro minim.", new DateTime(2020, 2, 14, 10, 2, 44, 857, DateTimeKind.Local).AddTicks(8104), "Gladiator" },
                    { 43, "Dictas contentiones no his, exerci oportere ea eam.", new DateTime(2020, 2, 14, 10, 2, 44, 857, DateTimeKind.Local).AddTicks(8108), "American History X" },
                    { 44, "No sonet omnes mnesarchum quo.", new DateTime(2020, 2, 14, 10, 2, 44, 857, DateTimeKind.Local).AddTicks(8111), "The Lion King" },
                    { 45, "Postea platonem has te, ei quod dicit sit, sea et movet delicata scribentur.", new DateTime(2020, 2, 14, 10, 2, 44, 857, DateTimeKind.Local).AddTicks(8114), "Terminator 2: Judgment Day" },
                    { 46, "Malis dictas detracto et ius, no qualisque vulputate per.", new DateTime(2020, 2, 14, 10, 2, 44, 857, DateTimeKind.Local).AddTicks(8117), "Cinema Paradiso" },
                    { 47, "Platonem oportere in has, nam recusabo delicata elaboraret ei, dico gubergren hendrerit ex sea.", new DateTime(2020, 2, 14, 10, 2, 44, 857, DateTimeKind.Local).AddTicks(8120), "Grave of the Fireflies" },
                    { 48, "Cu usu velit omittam temporibus, natum vulputate sea eu.", new DateTime(2020, 2, 14, 10, 2, 44, 857, DateTimeKind.Local).AddTicks(8126), "Back to the Future" },
                    { 27, "Ex atomorum repudiandae has, euismod vocibus ei eam, ei eam esse pertinacia abhorreant.", new DateTime(2020, 2, 14, 10, 2, 44, 857, DateTimeKind.Local).AddTicks(7991), "The Usual Suspects" },
                    { 26, "Clita mollis disputando cu eam, no pri insolens abhorreant.", new DateTime(2020, 2, 14, 10, 2, 44, 857, DateTimeKind.Local).AddTicks(7988), "Life Is Beautiful " },
                    { 25, "Eu adhuc percipit eleifend eam.", new DateTime(2020, 2, 14, 10, 2, 44, 857, DateTimeKind.Local).AddTicks(7985), "The Green Mile" },
                    { 24, "Has vocent alienum te.", new DateTime(2020, 2, 14, 10, 2, 44, 857, DateTimeKind.Local).AddTicks(7982), "Saving Private Ryan" },
                    { 2, "Eos dolor perpetua ne, cum agam causae petentium ei.", new DateTime(2020, 2, 14, 10, 2, 44, 857, DateTimeKind.Local).AddTicks(7863), "The Godfather" },
                    { 3, "At idque electram moderatius vix. Legere postulant at per.", new DateTime(2020, 2, 14, 10, 2, 44, 857, DateTimeKind.Local).AddTicks(7911), "The Dark Knight" },
                    { 4, "Sanctus fuisset pericula cu usu, mea an idque dicam accumsan.", new DateTime(2020, 2, 14, 10, 2, 44, 857, DateTimeKind.Local).AddTicks(7917), "The Godfather: Part II" },
                    { 5, "Et natum tollit sed.", new DateTime(2020, 2, 14, 10, 2, 44, 857, DateTimeKind.Local).AddTicks(7920), "The Lord of the Rings: The Return of the King" },
                    { 6, "Usu ad omnium civibus persecuti.", new DateTime(2020, 2, 14, 10, 2, 44, 857, DateTimeKind.Local).AddTicks(7924), "Pulp Fiction" },
                    { 7, "In graeco omnesque oporteat vim, ad sed nonumy consulatu.", new DateTime(2020, 2, 14, 10, 2, 44, 857, DateTimeKind.Local).AddTicks(7928), "Schindler's List" },
                    { 8, "Odio euismod et vel, has ad modo graecis pertinacia.", new DateTime(2020, 2, 14, 10, 2, 44, 857, DateTimeKind.Local).AddTicks(7931), "12 Angry Men" },
                    { 9, "Vim nibh solet scaevola te, sea illud posse partem an.", new DateTime(2020, 2, 14, 10, 2, 44, 857, DateTimeKind.Local).AddTicks(7934), "Inception" },
                    { 10, "Ad mea errem legimus efficiendi.", new DateTime(2020, 2, 14, 10, 2, 44, 857, DateTimeKind.Local).AddTicks(7937), "Fight Club" },
                    { 11, "Sale dolorum fabellas te cum, cu sea purto civibus menandri.", new DateTime(2020, 2, 14, 10, 2, 44, 857, DateTimeKind.Local).AddTicks(7940), "The Lord of the Rings: The Fellowship of the Ring" },
                    { 49, "Gubergren scriptorem eu vel, eius percipitur te per, vel tale habeo et.", new DateTime(2020, 2, 14, 10, 2, 44, 857, DateTimeKind.Local).AddTicks(8129), "Raiders of the Lost Ark" },
                    { 12, "Idque viris zril vel et.", new DateTime(2020, 2, 14, 10, 2, 44, 857, DateTimeKind.Local).AddTicks(7943), "Forrest Gump" },
                    { 14, "Cum meliore admodum ei, eos id summo audire, qui facilisi deterruisset ei.", new DateTime(2020, 2, 14, 10, 2, 44, 857, DateTimeKind.Local).AddTicks(7950), "Avengers: Endgame" },
                    { 15, "Vix ei falli salutatus eloquentiam.", new DateTime(2020, 2, 14, 10, 2, 44, 857, DateTimeKind.Local).AddTicks(7953), "The Lord of the Rings: The Two Towers" },
                    { 16, "Congue verear consetetur pri at.", new DateTime(2020, 2, 14, 10, 2, 44, 857, DateTimeKind.Local).AddTicks(7956), "The Matrix" },
                    { 17, "Ius eu sapientem constituam, aeque assueverit his ea, in homero graeco saperet quo.", new DateTime(2020, 2, 14, 10, 2, 44, 857, DateTimeKind.Local).AddTicks(7959), "Goodfellas" },
                    { 18, "Et est vero animal torquatos, illum principes eum ad, ad vocent iisque fuisset qui.", new DateTime(2020, 2, 14, 10, 2, 44, 857, DateTimeKind.Local).AddTicks(7962), "Star Wars: Episode V - The Empire Strikes Back" },
                    { 19, "Has vocent fastidii appareat ne, mel eu fabellas scripserit.", new DateTime(2020, 2, 14, 10, 2, 44, 857, DateTimeKind.Local).AddTicks(7965), "One Flew Over the Cuckoo's Nest" },
                    { 20, "Et duo iudico semper fabulas.", new DateTime(2020, 2, 14, 10, 2, 44, 857, DateTimeKind.Local).AddTicks(7968), "Seven Samurai" },
                    { 21, "Eos te volumus interesset, sint cotidieque eum et.", new DateTime(2020, 2, 14, 10, 2, 44, 857, DateTimeKind.Local).AddTicks(7972), "Interstellar" },
                    { 22, "Ad vel graece principes definitiones, ad vide populo vis, ex eos sumo efficiantur necessitatibus.", new DateTime(2020, 2, 14, 10, 2, 44, 857, DateTimeKind.Local).AddTicks(7975), "City of God" },
                    { 23, "Mel an sumo iusto, clita facilis adipiscing cum cu.", new DateTime(2020, 2, 14, 10, 2, 44, 857, DateTimeKind.Local).AddTicks(7979), "Spirited Away" },
                    { 13, "Ius ut luptatum democritum ullamcorper. Dolor possit facilis sit an, sit ei rebum meliore interesset.", new DateTime(2020, 2, 14, 10, 2, 44, 857, DateTimeKind.Local).AddTicks(7947), "The Good, the Bad and the Ugly" },
                    { 50, "Alii insolens inciderint pro an, ei eos utinam commodo tacimates.", new DateTime(2020, 2, 14, 10, 2, 44, 857, DateTimeKind.Local).AddTicks(8132), "Apocalypse Now" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movies_Title",
                table: "Movies",
                column: "Title");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
