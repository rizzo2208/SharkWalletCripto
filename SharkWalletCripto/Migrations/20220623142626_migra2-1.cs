using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharkWalletCripto.Migrations
{
    public partial class migra21 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Balances",
                columns: table => new
                {
                    BalanceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    balance = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Balances", x => x.BalanceID);
                });

            migrationBuilder.CreateTable(
                name: "MoneyCurrencies",
                columns: table => new
                {
                    MoneyCurrencyID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    moneyCurrency = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoneyCurrencies", x => x.MoneyCurrencyID);
                });

            migrationBuilder.CreateTable(
                name: "Wallets",
                columns: table => new
                {
                    AccountID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BalanceID = table.Column<int>(type: "int", nullable: false),
                    MoneyCurrencyID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoneyCurrencyID1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wallets", x => x.AccountID);
                    table.ForeignKey(
                        name: "FK_Wallets_Balances_BalanceID",
                        column: x => x.BalanceID,
                        principalTable: "Balances",
                        principalColumn: "BalanceID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Wallets_MoneyCurrencies_MoneyCurrencyID1",
                        column: x => x.MoneyCurrencyID1,
                        principalTable: "MoneyCurrencies",
                        principalColumn: "MoneyCurrencyID");
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountID = table.Column<int>(type: "int", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                    table.ForeignKey(
                        name: "FK_Users_Wallets_AccountID",
                        column: x => x.AccountID,
                        principalTable: "Wallets",
                        principalColumn: "AccountID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_AccountID",
                table: "Users",
                column: "AccountID");

            migrationBuilder.CreateIndex(
                name: "IX_Wallets_BalanceID",
                table: "Wallets",
                column: "BalanceID");

            migrationBuilder.CreateIndex(
                name: "IX_Wallets_MoneyCurrencyID1",
                table: "Wallets",
                column: "MoneyCurrencyID1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Wallets");

            migrationBuilder.DropTable(
                name: "Balances");

            migrationBuilder.DropTable(
                name: "MoneyCurrencies");
        }
    }
}
