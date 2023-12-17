using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CMSProjekt.Migrations
{
    /// <inheritdoc />
    public partial class addingelementsdbsets : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PageElements_File_FileId",
                table: "PageElements");

            migrationBuilder.DropForeignKey(
                name: "FK_PageElements_Image_ImageId",
                table: "PageElements");

            migrationBuilder.DropForeignKey(
                name: "FK_PageElements_Table_TableId",
                table: "PageElements");

            migrationBuilder.DropForeignKey(
                name: "FK_PageElements_Text_TextId",
                table: "PageElements");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Text",
                table: "Text");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Table",
                table: "Table");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Image",
                table: "Image");

            migrationBuilder.DropPrimaryKey(
                name: "PK_File",
                table: "File");

            migrationBuilder.RenameTable(
                name: "Text",
                newName: "Texts");

            migrationBuilder.RenameTable(
                name: "Table",
                newName: "Tables");

            migrationBuilder.RenameTable(
                name: "Image",
                newName: "Images");

            migrationBuilder.RenameTable(
                name: "File",
                newName: "Files");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Texts",
                table: "Texts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tables",
                table: "Tables",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Images",
                table: "Images",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Files",
                table: "Files",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PageElements_Files_FileId",
                table: "PageElements",
                column: "FileId",
                principalTable: "Files",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PageElements_Images_ImageId",
                table: "PageElements",
                column: "ImageId",
                principalTable: "Images",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PageElements_Tables_TableId",
                table: "PageElements",
                column: "TableId",
                principalTable: "Tables",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PageElements_Texts_TextId",
                table: "PageElements",
                column: "TextId",
                principalTable: "Texts",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PageElements_Files_FileId",
                table: "PageElements");

            migrationBuilder.DropForeignKey(
                name: "FK_PageElements_Images_ImageId",
                table: "PageElements");

            migrationBuilder.DropForeignKey(
                name: "FK_PageElements_Tables_TableId",
                table: "PageElements");

            migrationBuilder.DropForeignKey(
                name: "FK_PageElements_Texts_TextId",
                table: "PageElements");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Texts",
                table: "Texts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tables",
                table: "Tables");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Images",
                table: "Images");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Files",
                table: "Files");

            migrationBuilder.RenameTable(
                name: "Texts",
                newName: "Text");

            migrationBuilder.RenameTable(
                name: "Tables",
                newName: "Table");

            migrationBuilder.RenameTable(
                name: "Images",
                newName: "Image");

            migrationBuilder.RenameTable(
                name: "Files",
                newName: "File");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Text",
                table: "Text",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Table",
                table: "Table",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Image",
                table: "Image",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_File",
                table: "File",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PageElements_File_FileId",
                table: "PageElements",
                column: "FileId",
                principalTable: "File",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PageElements_Image_ImageId",
                table: "PageElements",
                column: "ImageId",
                principalTable: "Image",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PageElements_Table_TableId",
                table: "PageElements",
                column: "TableId",
                principalTable: "Table",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PageElements_Text_TextId",
                table: "PageElements",
                column: "TextId",
                principalTable: "Text",
                principalColumn: "Id");
        }
    }
}
