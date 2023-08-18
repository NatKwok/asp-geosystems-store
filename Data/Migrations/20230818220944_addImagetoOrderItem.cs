using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace asp_geosystems_store.Data.Migrations
{
    /// <inheritdoc />
    public partial class addImagetoOrderItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "OrderItems",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "OrderItems");
        }
    }
}
