using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CMSProjekt.Migrations
{
    /// <inheritdoc />
    public partial class addingpageelementstoelements : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropIndex(
                name: "IX_PageElements_FileId",
                table: "PageElements");

            migrationBuilder.DropIndex(
                name: "IX_PageElements_ImageId",
                table: "PageElements");

            migrationBuilder.DropIndex(
                name: "IX_PageElements_TableId",
                table: "PageElements");

            migrationBuilder.DropIndex(
                name: "IX_PageElements_TextId",
                table: "PageElements");

            migrationBuilder.DropColumn(
                name: "FileId",
                table: "PageElements");

            migrationBuilder.DropColumn(
                name: "ImageId",
                table: "PageElements");

            migrationBuilder.DropColumn(
                name: "TableId",
                table: "PageElements");

            migrationBuilder.DropColumn(
                name: "TextId",
                table: "PageElements");

            migrationBuilder.AddColumn<int>(
                name: "ElementId",
                table: "Texts",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ElementId",
                table: "Tables",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ElementId",
                table: "Images",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ElementId",
                table: "Files",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Texts_ElementId",
                table: "Texts",
                column: "ElementId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tables_ElementId",
                table: "Tables",
                column: "ElementId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Images_ElementId",
                table: "Images",
                column: "ElementId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Files_ElementId",
                table: "Files",
                column: "ElementId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Files_PageElements_ElementId",
                table: "Files",
                column: "ElementId",
                principalTable: "PageElements",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Images_PageElements_ElementId",
                table: "Images",
                column: "ElementId",
                principalTable: "PageElements",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tables_PageElements_ElementId",
                table: "Tables",
                column: "ElementId",
                principalTable: "PageElements",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Texts_PageElements_ElementId",
                table: "Texts",
                column: "ElementId",
                principalTable: "PageElements",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Files_PageElements_ElementId",
                table: "Files");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_PageElements_ElementId",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Tables_PageElements_ElementId",
                table: "Tables");

            migrationBuilder.DropForeignKey(
                name: "FK_Texts_PageElements_ElementId",
                table: "Texts");

            migrationBuilder.DropIndex(
                name: "IX_Texts_ElementId",
                table: "Texts");

            migrationBuilder.DropIndex(
                name: "IX_Tables_ElementId",
                table: "Tables");

            migrationBuilder.DropIndex(
                name: "IX_Images_ElementId",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Files_ElementId",
                table: "Files");

            migrationBuilder.DropColumn(
                name: "ElementId",
                table: "Texts");

            migrationBuilder.DropColumn(
                name: "ElementId",
                table: "Tables");

            migrationBuilder.DropColumn(
                name: "ElementId",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "ElementId",
                table: "Files");

            migrationBuilder.AddColumn<int>(
                name: "FileId",
                table: "PageElements",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ImageId",
                table: "PageElements",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TableId",
                table: "PageElements",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TextId",
                table: "PageElements",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PageElements_FileId",
                table: "PageElements",
                column: "FileId");

            migrationBuilder.CreateIndex(
                name: "IX_PageElements_ImageId",
                table: "PageElements",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_PageElements_TableId",
                table: "PageElements",
                column: "TableId");

            migrationBuilder.CreateIndex(
                name: "IX_PageElements_TextId",
                table: "PageElements",
                column: "TextId");

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
    }
}
