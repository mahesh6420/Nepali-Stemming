using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Stemming.Migrations
{
    public partial class rootsufficinputandstopwords : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblRoot",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    RootName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblRoot", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblStopword",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    StopWord = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblStopword", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblSuffix",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    SuffixName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblSuffix", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblInput",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    InputName = table.Column<string>(nullable: true),
                    RootId = table.Column<int>(nullable: true),
                    SuffixId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblInput", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblInput_tblRoot_RootId",
                        column: x => x.RootId,
                        principalTable: "tblRoot",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tblInput_tblSuffix_SuffixId",
                        column: x => x.SuffixId,
                        principalTable: "tblSuffix",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblInput_RootId",
                table: "tblInput",
                column: "RootId");

            migrationBuilder.CreateIndex(
                name: "IX_tblInput_SuffixId",
                table: "tblInput",
                column: "SuffixId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblInput");

            migrationBuilder.DropTable(
                name: "tblStopword");

            migrationBuilder.DropTable(
                name: "tblRoot");

            migrationBuilder.DropTable(
                name: "tblSuffix");
        }
    }
}
