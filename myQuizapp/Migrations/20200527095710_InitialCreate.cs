using Microsoft.EntityFrameworkCore.Migrations;

namespace myQuizapp.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Question",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Quest = table.Column<string>(nullable: true),
                    RightAnswer = table.Column<string>(nullable: true),
                    alt1 = table.Column<string>(nullable: true),
                    alt2 = table.Column<string>(nullable: true),
                    alt3 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Question", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Question");
        }
    }
}
