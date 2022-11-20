using Microsoft.EntityFrameworkCore.Migrations;

namespace High_precisionMechanics.Migrations
{
    public partial class Update2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "CustomerServiceManager",
                table: "Orders",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HeaOfProduction",
                table: "Orders",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HeadOfLogistics",
                table: "Orders",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HeadOfQualityDepartment",
                table: "Orders",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HeadOfTheEconomicDepartment",
                table: "Orders",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerServiceManager",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "HeaOfProduction",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "HeadOfLogistics",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "HeadOfQualityDepartment",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "HeadOfTheEconomicDepartment",
                table: "Orders");
        }
    }
}
