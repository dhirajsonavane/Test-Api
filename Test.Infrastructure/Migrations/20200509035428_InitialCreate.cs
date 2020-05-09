using Microsoft.EntityFrameworkCore.Migrations;

namespace Test.Infrastructure.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "VehicleType",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Monitoring",
                schema: "dbo",
                columns: table => new
                {
                    ImageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleId = table.Column<int>(nullable: false),
                    Time = table.Column<double>(nullable: false),
                    VehicleType = table.Column<int>(nullable: false),
                    Latitude = table.Column<double>(nullable: false),
                    Longitude = table.Column<double>(nullable: false),
                    Speed = table.Column<double>(nullable: false),
                    Acceleration = table.Column<double>(nullable: false),
                    X_Coordinate = table.Column<double>(nullable: false),
                    Y_Coordinate = table.Column<double>(nullable: false),
                    VehicleTypeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monitoring", x => x.ImageId);
                    table.ForeignKey(
                        name: "FK_Monitoring_VehicleType_VehicleTypeId",
                        column: x => x.VehicleTypeId,
                        principalSchema: "dbo",
                        principalTable: "VehicleType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Monitoring",
                columns: new[] { "ImageId", "Acceleration", "Latitude", "Longitude", "Speed", "Time", "VehicleId", "VehicleType", "VehicleTypeId", "X_Coordinate", "Y_Coordinate" },
                values: new object[,]
                {
                    { 35075, 5.5038479999999996, -27.559899999999999, 153.0813, 8.4702029999999997, 0.20000000000000001, 13403, 1, null, 536.0326, 537.37570000000005 },
                    { 35076, 5.416137, -27.559899999999999, 153.0813, 9.0118170000000006, 0.29999999999999999, 13403, 1, null, 570.40290000000005, 541.9049 },
                    { 35077, 5.0914289999999998, -27.559899999999999, 153.0813, 9.5209600000000005, 0.40000000000000002, 13403, 1, null, 606.14739999999995, 547.14059999999995 },
                    { 35078, 4.6128299999999998, -27.559899999999999, 153.0813, 9.9822430000000004, 0.5, 13403, 1, null, 643.63009999999997, 553.03420000000006 },
                    { 35079, 4.0377419999999997, -27.559899999999999, 153.0813, 10.38602, 0.59999999999999998, 13403, 1, null, 683.20780000000002, 559.53279999999995 }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "VehicleType",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Car" });

            migrationBuilder.CreateIndex(
                name: "IX_Monitoring_VehicleTypeId",
                schema: "dbo",
                table: "Monitoring",
                column: "VehicleTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Monitoring",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "VehicleType",
                schema: "dbo");
        }
    }
}
