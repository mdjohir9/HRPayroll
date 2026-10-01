using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class initial_db_with_pf_table_migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "Payroll_PFPolicy",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PolicyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContributionType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeContributionPercent = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    EmployerContributionPercent = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    EmployeeFixedAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    EmployerFixedAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CalculationBase = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WageLimit = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    MinWorkingDays = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CompanyId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payroll_PFPolicy", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Payroll_PFEmployees",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PFAccountNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmpJoiningDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PfActivationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VoluntaryPercent = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CompanyId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PFPolicyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payroll_PFEmployees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payroll_PFEmployees_Payroll_PFPolicy_PFPolicyId",
                        column: x => x.PFPolicyId,
                        principalSchema: "dbo",
                        principalTable: "Payroll_PFPolicy",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payroll_PFSettlement",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SettlementDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalBalance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentMode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    EmployeePFId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payroll_PFSettlement", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payroll_PFSettlement_Payroll_PFEmployees_EmployeePFId",
                        column: x => x.EmployeePFId,
                        principalSchema: "dbo",
                        principalTable: "Payroll_PFEmployees",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Payroll_PFTransaction",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransactionMonth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmployeeContribution = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EmployerContribution = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<int>(type: "int", nullable: true),
                    IsManual = table.Column<bool>(type: "bit", nullable: true),
                    CompanyId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeePFId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payroll_PFTransaction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payroll_PFTransaction_Payroll_PFEmployees_EmployeePFId",
                        column: x => x.EmployeePFId,
                        principalSchema: "dbo",
                        principalTable: "Payroll_PFEmployees",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Payroll_PFEmployees_PFPolicyId",
                schema: "dbo",
                table: "Payroll_PFEmployees",
                column: "PFPolicyId");

            migrationBuilder.CreateIndex(
                name: "IX_Payroll_PFSettlement_EmployeePFId",
                schema: "dbo",
                table: "Payroll_PFSettlement",
                column: "EmployeePFId");

            migrationBuilder.CreateIndex(
                name: "IX_Payroll_PFTransaction_EmployeePFId",
                schema: "dbo",
                table: "Payroll_PFTransaction",
                column: "EmployeePFId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Payroll_PFSettlement",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Payroll_PFTransaction",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Payroll_PFEmployees",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Payroll_PFPolicy",
                schema: "dbo");
        }
    }
}
