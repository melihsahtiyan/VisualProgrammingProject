using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class OrderChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FromWhere",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ToWhere",
                table: "Orders");

            migrationBuilder.AddColumn<int>(
                name: "CustomerWarehouseId",
                table: "Orders",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ManufacturerWarehouseId",
                table: "Orders",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerWarehouseId",
                table: "Orders",
                column: "CustomerWarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ManufacturerWarehouseId",
                table: "Orders",
                column: "ManufacturerWarehouseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Warehouses_CustomerWarehouseId",
                table: "Orders",
                column: "CustomerWarehouseId",
                principalTable: "Warehouses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Warehouses_ManufacturerWarehouseId",
                table: "Orders",
                column: "ManufacturerWarehouseId",
                principalTable: "Warehouses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Warehouses_CustomerWarehouseId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Warehouses_ManufacturerWarehouseId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_CustomerWarehouseId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_ManufacturerWarehouseId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "CustomerWarehouseId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ManufacturerWarehouseId",
                table: "Orders");

            migrationBuilder.AddColumn<string>(
                name: "FromWhere",
                table: "Orders",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ToWhere",
                table: "Orders",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
