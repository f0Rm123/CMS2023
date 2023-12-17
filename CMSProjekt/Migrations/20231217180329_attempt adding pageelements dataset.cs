using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CMSProjekt.Migrations
{
    /// <inheritdoc />
    public partial class attemptaddingpageelementsdataset : Migration
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
                name: "FK_PageElement_Pages_PageId",
                table: "PageElement");

            migrationBuilder.DropForeignKey(
                name: "FK_PageElement_Table_TableId",
                table: "PageElement");

            migrationBuilder.DropForeignKey(
                name: "FK_PageElement_Text_TextId",
                table: "PageElement");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PageElement",
                table: "PageElement");

            migrationBuilder.RenameTable(
                name: "PageElement",
                newName: "PageElements");

            migrationBuilder.RenameIndex(
                name: "IX_PageElement_TextId",
                table: "PageElements",
                newName: "IX_PageElements_TextId");

            migrationBuilder.RenameIndex(
                name: "IX_PageElement_TableId",
                table: "PageElements",
                newName: "IX_PageElements_TableId");

            migrationBuilder.RenameIndex(
                name: "IX_PageElement_PageId",
                table: "PageElements",
                newName: "IX_PageElements_PageId");

            migrationBuilder.RenameIndex(
                name: "IX_PageElement_ImageId",
                table: "PageElements",
                newName: "IX_PageElements_ImageId");

            migrationBuilder.RenameIndex(
                name: "IX_PageElement_FileId",
                table: "PageElements",
                newName: "IX_PageElements_FileId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PageElements",
                table: "PageElements",
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
                name: "FK_PageElements_Pages_PageId",
                table: "PageElements",
                column: "PageId",
                principalTable: "Pages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PageElements_File_FileId",
                table: "PageElements");

            migrationBuilder.DropForeignKey(
                name: "FK_PageElements_Image_ImageId",
                table: "PageElements");

            migrationBuilder.DropForeignKey(
                name: "FK_PageElements_Pages_PageId",
                table: "PageElements");

            migrationBuilder.DropForeignKey(
                name: "FK_PageElements_Table_TableId",
                table: "PageElements");

            migrationBuilder.DropForeignKey(
                name: "FK_PageElements_Text_TextId",
                table: "PageElements");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PageElements",
                table: "PageElements");

            migrationBuilder.RenameTable(
                name: "PageElements",
                newName: "PageElement");

            migrationBuilder.RenameIndex(
                name: "IX_PageElements_TextId",
                table: "PageElement",
                newName: "IX_PageElement_TextId");

            migrationBuilder.RenameIndex(
                name: "IX_PageElements_TableId",
                table: "PageElement",
                newName: "IX_PageElement_TableId");

            migrationBuilder.RenameIndex(
                name: "IX_PageElements_PageId",
                table: "PageElement",
                newName: "IX_PageElement_PageId");

            migrationBuilder.RenameIndex(
                name: "IX_PageElements_ImageId",
                table: "PageElement",
                newName: "IX_PageElement_ImageId");

            migrationBuilder.RenameIndex(
                name: "IX_PageElements_FileId",
                table: "PageElement",
                newName: "IX_PageElement_FileId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PageElement",
                table: "PageElement",
                column: "Id");

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
                name: "FK_PageElement_Pages_PageId",
                table: "PageElement",
                column: "PageId",
                principalTable: "Pages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
    }
}
