using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieTicketShop.Migrations
{
    /// <inheritdoc />
    public partial class secondUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id",
                table: "Actors_Movies");

            migrationBuilder.RenameColumn(
                name: "MoviePicture",
                table: "Movies",
                newName: "MoviePictureURL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MoviePictureURL",
                table: "Movies",
                newName: "MoviePicture");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Actors_Movies",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
