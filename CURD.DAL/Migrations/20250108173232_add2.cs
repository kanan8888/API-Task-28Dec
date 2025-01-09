using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CURD.DAL.Migrations
{
    /// <inheritdoc />
    public partial class add2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "TagProducts");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "TagProducts",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
