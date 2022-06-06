using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class mir10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Factures_Clients_ClientFk",
                table: "Factures");

            migrationBuilder.DropForeignKey(
                name: "FK_Factures_Products_ProductFk",
                table: "Factures");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Factures",
                table: "Factures");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clients",
                table: "Clients");

            migrationBuilder.RenameTable(
                name: "Factures",
                newName: "Facture");

            migrationBuilder.RenameTable(
                name: "Clients",
                newName: "Client");

            migrationBuilder.RenameIndex(
                name: "IX_Factures_ProductFk",
                table: "Facture",
                newName: "IX_Facture_ProductFk");

            migrationBuilder.RenameIndex(
                name: "IX_Factures_ClientFk",
                table: "Facture",
                newName: "IX_Facture_ClientFk");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Facture",
                table: "Facture",
                columns: new[] { "DateAchat", "ClientFk", "ProductFk" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Client",
                table: "Client",
                column: "CIN");

            migrationBuilder.AddForeignKey(
                name: "FK_Facture_Client_ClientFk",
                table: "Facture",
                column: "ClientFk",
                principalTable: "Client",
                principalColumn: "CIN",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Facture_Products_ProductFk",
                table: "Facture",
                column: "ProductFk",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Facture_Client_ClientFk",
                table: "Facture");

            migrationBuilder.DropForeignKey(
                name: "FK_Facture_Products_ProductFk",
                table: "Facture");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Facture",
                table: "Facture");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Client",
                table: "Client");

            migrationBuilder.RenameTable(
                name: "Facture",
                newName: "Factures");

            migrationBuilder.RenameTable(
                name: "Client",
                newName: "Clients");

            migrationBuilder.RenameIndex(
                name: "IX_Facture_ProductFk",
                table: "Factures",
                newName: "IX_Factures_ProductFk");

            migrationBuilder.RenameIndex(
                name: "IX_Facture_ClientFk",
                table: "Factures",
                newName: "IX_Factures_ClientFk");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Factures",
                table: "Factures",
                columns: new[] { "DateAchat", "ClientFk", "ProductFk" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clients",
                table: "Clients",
                column: "CIN");

            migrationBuilder.AddForeignKey(
                name: "FK_Factures_Clients_ClientFk",
                table: "Factures",
                column: "ClientFk",
                principalTable: "Clients",
                principalColumn: "CIN",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Factures_Products_ProductFk",
                table: "Factures",
                column: "ProductFk",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
