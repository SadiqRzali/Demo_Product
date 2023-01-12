using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAcssesLayer.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "JobID",
                table: "Customers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "jobs",
                columns: table => new
                {
                    JobID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jobs", x => x.JobID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_JobID",
                table: "Customers",
                column: "JobID");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_jobs_JobID",
                table: "Customers",
                column: "JobID",
                principalTable: "jobs",
                principalColumn: "JobID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_jobs_JobID",
                table: "Customers");

            migrationBuilder.DropTable(
                name: "jobs");

            migrationBuilder.DropIndex(
                name: "IX_Customers_JobID",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "JobID",
                table: "Customers");
        }
    }
}
