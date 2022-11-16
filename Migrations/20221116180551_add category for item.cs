using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sneakerz.Migrations
{
    /// <inheritdoc />
    public partial class addcategoryforitem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CaregoryId",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CaregoryId",
                table: "Items");
        }
    }
}
