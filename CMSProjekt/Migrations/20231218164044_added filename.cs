﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CMSProjekt.Migrations
{
    /// <inheritdoc />
    public partial class addedfilename : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Files",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Files");
        }
    }
}
