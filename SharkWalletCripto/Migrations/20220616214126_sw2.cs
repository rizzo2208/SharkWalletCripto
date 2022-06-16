using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharkWalletCripto.Migrations
{
    public partial class sw2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Balance",
                table: "Wallets");

            migrationBuilder.DropColumn(
                name: "Value",
                table: "MoneyCurrencies");

            migrationBuilder.AddColumn<int>(
                name: "BalanceID",
                table: "Wallets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Balance",
                columns: table => new
                {
                    BalanceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    balance = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Balance", x => x.BalanceID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Wallets_BalanceID",
                table: "Wallets",
                column: "BalanceID");

            migrationBuilder.AddForeignKey(
                name: "FK_Wallets_Balance_BalanceID",
                table: "Wallets",
                column: "BalanceID",
                principalTable: "Balance",
                principalColumn: "BalanceID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Wallets_Balance_BalanceID",
                table: "Wallets");

            migrationBuilder.DropTable(
                name: "Balance");

            migrationBuilder.DropIndex(
                name: "IX_Wallets_BalanceID",
                table: "Wallets");

            migrationBuilder.DropColumn(
                name: "BalanceID",
                table: "Wallets");

            migrationBuilder.AddColumn<double>(
                name: "Balance",
                table: "Wallets",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Value",
                table: "MoneyCurrencies",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
