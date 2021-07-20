using Microsoft.EntityFrameworkCore.Migrations;

namespace BackendCreditCards.Migrations
{
    public partial class v100 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CreditCard",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cardOwner = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cardNum = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    expirationDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cvv = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreditCard", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CreditCard");
        }
    }
}
