using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cp2___dotnet.Migrations
{
    /// <inheritdoc />
    public partial class UpdatePedidoModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClienteId1",
                table: "Pedidos",
                type: "NUMBER(10)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_ClienteId1",
                table: "Pedidos",
                column: "ClienteId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Clientes_ClienteId1",
                table: "Pedidos",
                column: "ClienteId1",
                principalTable: "Clientes",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Clientes_ClienteId1",
                table: "Pedidos");

            migrationBuilder.DropIndex(
                name: "IX_Pedidos_ClienteId1",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "ClienteId1",
                table: "Pedidos");
        }
    }
}
