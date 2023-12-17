using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CMSProjekt.Migrations
{
    /// <inheritdoc />
    public partial class FixedPKFile : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PageElement_File_FileId",
                table: "PageElement");

            migrationBuilder.AlterColumn<int>(
                name: "FileId",
                table: "PageElement",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "File",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddForeignKey(
                name: "FK_PageElement_File_FileId",
                table: "PageElement",
                column: "FileId",
                principalTable: "File",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PageElement_File_FileId",
                table: "PageElement");

            migrationBuilder.AlterColumn<string>(
                name: "FileId",
                table: "PageElement",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "File",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddForeignKey(
                name: "FK_PageElement_File_FileId",
                table: "PageElement",
                column: "FileId",
                principalTable: "File",
                principalColumn: "Id");
        }
    }
}
