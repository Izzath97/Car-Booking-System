using Microsoft.EntityFrameworkCore.Migrations;

namespace banger.Migrations
{
    public partial class mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "VehicleType",
                table: "Vehicle",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Class",
                table: "Vehicle",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Doors",
                table: "Vehicle",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Facilities",
                table: "Vehicle",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FuelType",
                table: "Vehicle",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GearBox",
                table: "Vehicle",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Users",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Users",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "VehicleNo",
                table: "Bookings",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LicenseNo",
                table: "Bookings",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Class",
                table: "Vehicle");

            migrationBuilder.DropColumn(
                name: "Doors",
                table: "Vehicle");

            migrationBuilder.DropColumn(
                name: "Facilities",
                table: "Vehicle");

            migrationBuilder.DropColumn(
                name: "FuelType",
                table: "Vehicle");

            migrationBuilder.DropColumn(
                name: "GearBox",
                table: "Vehicle");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Users");

            migrationBuilder.AlterColumn<string>(
                name: "VehicleType",
                table: "Vehicle",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Users",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "VehicleNo",
                table: "Bookings",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LicenseNo",
                table: "Bookings",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
