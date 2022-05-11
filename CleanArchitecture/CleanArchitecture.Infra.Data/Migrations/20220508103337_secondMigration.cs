using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CleanArchitecture.Infra.Data.Migrations
{
    public partial class secondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    login = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContractLocationHistories",
                columns: table => new
                {
                    ContractLocationHistoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    ContractReference = table.Column<int>(nullable: false),
                    DurationRetainedUnderIFRS16 = table.Column<int>(nullable: false),
                    AnnulRent = table.Column<int>(nullable: false),
                    PayementFrequency = table.Column<int>(nullable: false),
                    MonthsNumber = table.Column<int>(nullable: false),
                    Annulncrease = table.Column<int>(nullable: false),
                    IncreaseFrequency = table.Column<int>(nullable: false),
                    increaseDate = table.Column<int>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    DiscountRate = table.Column<int>(nullable: false),
                    PrepaidExpensesPayementDate = table.Column<DateTime>(nullable: false),
                    PrepaidExpensesPeriodCovered = table.Column<string>(nullable: true),
                    RenewalOption_Id = table.Column<int>(nullable: false),
                    tenant_id = table.Column<int>(nullable: false),
                    DateExcuteUpdate = table.Column<DateTime>(nullable: false),
                    DateReference = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractLocationHistories", x => x.ContractLocationHistoryId);
                });

            migrationBuilder.CreateTable(
                name: "ContractLocations",
                columns: table => new
                {
                    ContactLocationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContractReference = table.Column<int>(nullable: false),
                    DurationRetainedUnderIFRS16 = table.Column<int>(nullable: false),
                    AnnulRent = table.Column<int>(nullable: false),
                    PayementFrequency = table.Column<int>(nullable: false),
                    MonthsNumber = table.Column<int>(nullable: false),
                    Annulncrease = table.Column<int>(nullable: false),
                    IncreaseFrequency = table.Column<int>(nullable: false),
                    increaseDate = table.Column<int>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    DiscountRate = table.Column<int>(nullable: false),
                    PrepaidExpensesPayementDate = table.Column<DateTime>(nullable: false),
                    PrepaidExpensesPeriodCovered = table.Column<string>(nullable: true),
                    RenewalOption_Id = table.Column<int>(nullable: false),
                    tenant_id = table.Column<int>(nullable: false),
                    DateExcuteUpdate = table.Column<DateTime>(nullable: false),
                    DateReference = table.Column<DateTime>(nullable: false),
                    ContractLocationHistoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractLocations", x => x.ContactLocationId);
                    table.ForeignKey(
                        name: "FK_ContractLocations_ContractLocationHistories_ContractLocationHistoryId",
                        column: x => x.ContractLocationHistoryId,
                        principalTable: "ContractLocationHistories",
                        principalColumn: "ContractLocationHistoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContractLocations_ContractLocationHistoryId",
                table: "ContractLocations",
                column: "ContractLocationHistoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "ContractLocations");

            migrationBuilder.DropTable(
                name: "ContractLocationHistories");
        }
    }
}
