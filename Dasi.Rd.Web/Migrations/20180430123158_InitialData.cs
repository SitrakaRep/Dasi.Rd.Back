using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Dasi.Rd.Web.Migrations
{
    public partial class InitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Synoda",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateEdition = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SynodaName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SynodaNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Synoda", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Fitandremana",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateEdition = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FitandremanaAdress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FitandremanaName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SynodaID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fitandremana", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Fitandremana_Synoda_SynodaID",
                        column: x => x.SynodaID,
                        principalTable: "Synoda",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Fitandremana_SynodaID",
                table: "Fitandremana",
                column: "SynodaID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fitandremana");

            migrationBuilder.DropTable(
                name: "Synoda");
        }
    }
}
