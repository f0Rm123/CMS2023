using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CMSProjekt.Migrations
{
    /// <inheritdoc />
    public partial class attemptonnullableobjectsinpageelement : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PageElement_File_FileId",
                table: "PageElement");

            migrationBuilder.DropForeignKey(
                name: "FK_PageElement_Image_ImageId",
                table: "PageElement");

            migrationBuilder.DropForeignKey(
                name: "FK_PageElement_Table_TableId",
                table: "PageElement");

            migrationBuilder.DropForeignKey(
                name: "FK_PageElement_Text_TextId",
                table: "PageElement");

            migrationBuilder.AlterColumn<int>(
                name: "TextId",
                table: "PageElement",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "TableId",
                table: "PageElement",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "ImageId",
                table: "PageElement",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "FileId",
                table: "PageElement",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_PageElement_File_FileId",
                table: "PageElement",
                column: "FileId",
                principalTable: "File",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PageElement_Image_ImageId",
                table: "PageElement",
                column: "ImageId",
                principalTable: "Image",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PageElement_Table_TableId",
                table: "PageElement",
                column: "TableId",
                principalTable: "Table",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PageElement_Text_TextId",
                table: "PageElement",
                column: "TextId",
                principalTable: "Text",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PageElement_File_FileId",
                table: "PageElement");

            migrationBuilder.DropForeignKey(
                name: "FK_PageElement_Image_ImageId",
                table: "PageElement");

            migrationBuilder.DropForeignKey(
                name: "FK_PageElement_Table_TableId",
                table: "PageElement");

            migrationBuilder.DropForeignKey(
                name: "FK_PageElement_Text_TextId",
                table: "PageElement");

            migrationBuilder.AlterColumn<int>(
                name: "TextId",
                table: "PageElement",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TableId",
                table: "PageElement",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ImageId",
                table: "PageElement",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FileId",
                table: "PageElement",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PageElement_File_FileId",
                table: "PageElement",
                column: "FileId",
                principalTable: "File",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PageElement_Image_ImageId",
                table: "PageElement",
                column: "ImageId",
                principalTable: "Image",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PageElement_Table_TableId",
                table: "PageElement",
                column: "TableId",
                principalTable: "Table",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PageElement_Text_TextId",
                table: "PageElement",
                column: "TextId",
                principalTable: "Text",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
