using Microsoft.EntityFrameworkCore.Migrations;

namespace DataVisual.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FD1RULs",
                columns: table => new
                {
                    EngineID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RUL = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FD1RULs", x => x.EngineID);
                });

            migrationBuilder.CreateTable(
                name: "FD1TESTs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EngineID = table.Column<int>(type: "int", nullable: false),
                    Cycle = table.Column<int>(type: "int", nullable: false),
                    Setting_1 = table.Column<float>(type: "real", nullable: false),
                    Setting_2 = table.Column<float>(type: "real", nullable: false),
                    Setting_3 = table.Column<float>(type: "real", nullable: false),
                    SensorData_1 = table.Column<float>(type: "real", nullable: false),
                    SensorData_2 = table.Column<float>(type: "real", nullable: false),
                    SensorData_3 = table.Column<float>(type: "real", nullable: false),
                    SensorData_4 = table.Column<float>(type: "real", nullable: false),
                    SensorData_5 = table.Column<float>(type: "real", nullable: false),
                    SensorData_6 = table.Column<float>(type: "real", nullable: false),
                    SensorData_7 = table.Column<float>(type: "real", nullable: false),
                    SensorData_8 = table.Column<float>(type: "real", nullable: false),
                    SensorData_9 = table.Column<float>(type: "real", nullable: false),
                    SensorData_10 = table.Column<float>(type: "real", nullable: false),
                    SensorData_11 = table.Column<float>(type: "real", nullable: false),
                    SensorData_12 = table.Column<float>(type: "real", nullable: false),
                    SensorData_13 = table.Column<float>(type: "real", nullable: false),
                    SensorData_14 = table.Column<float>(type: "real", nullable: false),
                    SensorData_15 = table.Column<float>(type: "real", nullable: false),
                    SensorData_16 = table.Column<float>(type: "real", nullable: false),
                    SensorData_17 = table.Column<float>(type: "real", nullable: false),
                    SensorData_18 = table.Column<float>(type: "real", nullable: false),
                    SensorData_19 = table.Column<float>(type: "real", nullable: false),
                    SensorData_20 = table.Column<float>(type: "real", nullable: false),
                    SensorData_21 = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FD1TESTs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FD1TRAINs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EngineID = table.Column<int>(type: "int", nullable: false),
                    Cycle = table.Column<int>(type: "int", nullable: false),
                    Setting_1 = table.Column<float>(type: "real", nullable: false),
                    Setting_2 = table.Column<float>(type: "real", nullable: false),
                    Setting_3 = table.Column<float>(type: "real", nullable: false),
                    SensorData_1 = table.Column<float>(type: "real", nullable: false),
                    SensorData_2 = table.Column<float>(type: "real", nullable: false),
                    SensorData_3 = table.Column<float>(type: "real", nullable: false),
                    SensorData_4 = table.Column<float>(type: "real", nullable: false),
                    SensorData_5 = table.Column<float>(type: "real", nullable: false),
                    SensorData_6 = table.Column<float>(type: "real", nullable: false),
                    SensorData_7 = table.Column<float>(type: "real", nullable: false),
                    SensorData_8 = table.Column<float>(type: "real", nullable: false),
                    SensorData_9 = table.Column<float>(type: "real", nullable: false),
                    SensorData_10 = table.Column<float>(type: "real", nullable: false),
                    SensorData_11 = table.Column<float>(type: "real", nullable: false),
                    SensorData_12 = table.Column<float>(type: "real", nullable: false),
                    SensorData_13 = table.Column<float>(type: "real", nullable: false),
                    SensorData_14 = table.Column<float>(type: "real", nullable: false),
                    SensorData_15 = table.Column<float>(type: "real", nullable: false),
                    SensorData_16 = table.Column<float>(type: "real", nullable: false),
                    SensorData_17 = table.Column<float>(type: "real", nullable: false),
                    SensorData_18 = table.Column<float>(type: "real", nullable: false),
                    SensorData_19 = table.Column<float>(type: "real", nullable: false),
                    SensorData_20 = table.Column<float>(type: "real", nullable: false),
                    SensorData_21 = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FD1TRAINs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FD2RULs",
                columns: table => new
                {
                    EngineID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RUL = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FD2RULs", x => x.EngineID);
                });

            migrationBuilder.CreateTable(
                name: "FD2TESTs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EngineID = table.Column<int>(type: "int", nullable: false),
                    Cycle = table.Column<int>(type: "int", nullable: false),
                    Setting_1 = table.Column<float>(type: "real", nullable: false),
                    Setting_2 = table.Column<float>(type: "real", nullable: false),
                    Setting_3 = table.Column<float>(type: "real", nullable: false),
                    SensorData_1 = table.Column<float>(type: "real", nullable: false),
                    SensorData_2 = table.Column<float>(type: "real", nullable: false),
                    SensorData_3 = table.Column<float>(type: "real", nullable: false),
                    SensorData_4 = table.Column<float>(type: "real", nullable: false),
                    SensorData_5 = table.Column<float>(type: "real", nullable: false),
                    SensorData_6 = table.Column<float>(type: "real", nullable: false),
                    SensorData_7 = table.Column<float>(type: "real", nullable: false),
                    SensorData_8 = table.Column<float>(type: "real", nullable: false),
                    SensorData_9 = table.Column<float>(type: "real", nullable: false),
                    SensorData_10 = table.Column<float>(type: "real", nullable: false),
                    SensorData_11 = table.Column<float>(type: "real", nullable: false),
                    SensorData_12 = table.Column<float>(type: "real", nullable: false),
                    SensorData_13 = table.Column<float>(type: "real", nullable: false),
                    SensorData_14 = table.Column<float>(type: "real", nullable: false),
                    SensorData_15 = table.Column<float>(type: "real", nullable: false),
                    SensorData_16 = table.Column<float>(type: "real", nullable: false),
                    SensorData_17 = table.Column<float>(type: "real", nullable: false),
                    SensorData_18 = table.Column<float>(type: "real", nullable: false),
                    SensorData_19 = table.Column<float>(type: "real", nullable: false),
                    SensorData_20 = table.Column<float>(type: "real", nullable: false),
                    SensorData_21 = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FD2TESTs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FD2TRAINs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EngineID = table.Column<int>(type: "int", nullable: false),
                    Cycle = table.Column<int>(type: "int", nullable: false),
                    Setting_1 = table.Column<float>(type: "real", nullable: false),
                    Setting_2 = table.Column<float>(type: "real", nullable: false),
                    Setting_3 = table.Column<float>(type: "real", nullable: false),
                    SensorData_1 = table.Column<float>(type: "real", nullable: false),
                    SensorData_2 = table.Column<float>(type: "real", nullable: false),
                    SensorData_3 = table.Column<float>(type: "real", nullable: false),
                    SensorData_4 = table.Column<float>(type: "real", nullable: false),
                    SensorData_5 = table.Column<float>(type: "real", nullable: false),
                    SensorData_6 = table.Column<float>(type: "real", nullable: false),
                    SensorData_7 = table.Column<float>(type: "real", nullable: false),
                    SensorData_8 = table.Column<float>(type: "real", nullable: false),
                    SensorData_9 = table.Column<float>(type: "real", nullable: false),
                    SensorData_10 = table.Column<float>(type: "real", nullable: false),
                    SensorData_11 = table.Column<float>(type: "real", nullable: false),
                    SensorData_12 = table.Column<float>(type: "real", nullable: false),
                    SensorData_13 = table.Column<float>(type: "real", nullable: false),
                    SensorData_14 = table.Column<float>(type: "real", nullable: false),
                    SensorData_15 = table.Column<float>(type: "real", nullable: false),
                    SensorData_16 = table.Column<float>(type: "real", nullable: false),
                    SensorData_17 = table.Column<float>(type: "real", nullable: false),
                    SensorData_18 = table.Column<float>(type: "real", nullable: false),
                    SensorData_19 = table.Column<float>(type: "real", nullable: false),
                    SensorData_20 = table.Column<float>(type: "real", nullable: false),
                    SensorData_21 = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FD2TRAINs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FD3RULs",
                columns: table => new
                {
                    EngineID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RUL = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FD3RULs", x => x.EngineID);
                });

            migrationBuilder.CreateTable(
                name: "FD3TESTs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EngineID = table.Column<int>(type: "int", nullable: false),
                    Cycle = table.Column<int>(type: "int", nullable: false),
                    Setting_1 = table.Column<float>(type: "real", nullable: false),
                    Setting_2 = table.Column<float>(type: "real", nullable: false),
                    Setting_3 = table.Column<float>(type: "real", nullable: false),
                    SensorData_1 = table.Column<float>(type: "real", nullable: false),
                    SensorData_2 = table.Column<float>(type: "real", nullable: false),
                    SensorData_3 = table.Column<float>(type: "real", nullable: false),
                    SensorData_4 = table.Column<float>(type: "real", nullable: false),
                    SensorData_5 = table.Column<float>(type: "real", nullable: false),
                    SensorData_6 = table.Column<float>(type: "real", nullable: false),
                    SensorData_7 = table.Column<float>(type: "real", nullable: false),
                    SensorData_8 = table.Column<float>(type: "real", nullable: false),
                    SensorData_9 = table.Column<float>(type: "real", nullable: false),
                    SensorData_10 = table.Column<float>(type: "real", nullable: false),
                    SensorData_11 = table.Column<float>(type: "real", nullable: false),
                    SensorData_12 = table.Column<float>(type: "real", nullable: false),
                    SensorData_13 = table.Column<float>(type: "real", nullable: false),
                    SensorData_14 = table.Column<float>(type: "real", nullable: false),
                    SensorData_15 = table.Column<float>(type: "real", nullable: false),
                    SensorData_16 = table.Column<float>(type: "real", nullable: false),
                    SensorData_17 = table.Column<float>(type: "real", nullable: false),
                    SensorData_18 = table.Column<float>(type: "real", nullable: false),
                    SensorData_19 = table.Column<float>(type: "real", nullable: false),
                    SensorData_20 = table.Column<float>(type: "real", nullable: false),
                    SensorData_21 = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FD3TESTs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FD3TRAINs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EngineID = table.Column<int>(type: "int", nullable: false),
                    Cycle = table.Column<int>(type: "int", nullable: false),
                    Setting_1 = table.Column<float>(type: "real", nullable: false),
                    Setting_2 = table.Column<float>(type: "real", nullable: false),
                    Setting_3 = table.Column<float>(type: "real", nullable: false),
                    SensorData_1 = table.Column<float>(type: "real", nullable: false),
                    SensorData_2 = table.Column<float>(type: "real", nullable: false),
                    SensorData_3 = table.Column<float>(type: "real", nullable: false),
                    SensorData_4 = table.Column<float>(type: "real", nullable: false),
                    SensorData_5 = table.Column<float>(type: "real", nullable: false),
                    SensorData_6 = table.Column<float>(type: "real", nullable: false),
                    SensorData_7 = table.Column<float>(type: "real", nullable: false),
                    SensorData_8 = table.Column<float>(type: "real", nullable: false),
                    SensorData_9 = table.Column<float>(type: "real", nullable: false),
                    SensorData_10 = table.Column<float>(type: "real", nullable: false),
                    SensorData_11 = table.Column<float>(type: "real", nullable: false),
                    SensorData_12 = table.Column<float>(type: "real", nullable: false),
                    SensorData_13 = table.Column<float>(type: "real", nullable: false),
                    SensorData_14 = table.Column<float>(type: "real", nullable: false),
                    SensorData_15 = table.Column<float>(type: "real", nullable: false),
                    SensorData_16 = table.Column<float>(type: "real", nullable: false),
                    SensorData_17 = table.Column<float>(type: "real", nullable: false),
                    SensorData_18 = table.Column<float>(type: "real", nullable: false),
                    SensorData_19 = table.Column<float>(type: "real", nullable: false),
                    SensorData_20 = table.Column<float>(type: "real", nullable: false),
                    SensorData_21 = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FD3TRAINs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FD4RULs",
                columns: table => new
                {
                    EngineID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RUL = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FD4RULs", x => x.EngineID);
                });

            migrationBuilder.CreateTable(
                name: "FD4TESTs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EngineID = table.Column<int>(type: "int", nullable: false),
                    Cycle = table.Column<int>(type: "int", nullable: false),
                    Setting_1 = table.Column<float>(type: "real", nullable: false),
                    Setting_2 = table.Column<float>(type: "real", nullable: false),
                    Setting_3 = table.Column<float>(type: "real", nullable: false),
                    SensorData_1 = table.Column<float>(type: "real", nullable: false),
                    SensorData_2 = table.Column<float>(type: "real", nullable: false),
                    SensorData_3 = table.Column<float>(type: "real", nullable: false),
                    SensorData_4 = table.Column<float>(type: "real", nullable: false),
                    SensorData_5 = table.Column<float>(type: "real", nullable: false),
                    SensorData_6 = table.Column<float>(type: "real", nullable: false),
                    SensorData_7 = table.Column<float>(type: "real", nullable: false),
                    SensorData_8 = table.Column<float>(type: "real", nullable: false),
                    SensorData_9 = table.Column<float>(type: "real", nullable: false),
                    SensorData_10 = table.Column<float>(type: "real", nullable: false),
                    SensorData_11 = table.Column<float>(type: "real", nullable: false),
                    SensorData_12 = table.Column<float>(type: "real", nullable: false),
                    SensorData_13 = table.Column<float>(type: "real", nullable: false),
                    SensorData_14 = table.Column<float>(type: "real", nullable: false),
                    SensorData_15 = table.Column<float>(type: "real", nullable: false),
                    SensorData_16 = table.Column<float>(type: "real", nullable: false),
                    SensorData_17 = table.Column<float>(type: "real", nullable: false),
                    SensorData_18 = table.Column<float>(type: "real", nullable: false),
                    SensorData_19 = table.Column<float>(type: "real", nullable: false),
                    SensorData_20 = table.Column<float>(type: "real", nullable: false),
                    SensorData_21 = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FD4TESTs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FD4TRAINs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EngineID = table.Column<int>(type: "int", nullable: false),
                    Cycle = table.Column<int>(type: "int", nullable: false),
                    Setting_1 = table.Column<float>(type: "real", nullable: false),
                    Setting_2 = table.Column<float>(type: "real", nullable: false),
                    Setting_3 = table.Column<float>(type: "real", nullable: false),
                    SensorData_1 = table.Column<float>(type: "real", nullable: false),
                    SensorData_2 = table.Column<float>(type: "real", nullable: false),
                    SensorData_3 = table.Column<float>(type: "real", nullable: false),
                    SensorData_4 = table.Column<float>(type: "real", nullable: false),
                    SensorData_5 = table.Column<float>(type: "real", nullable: false),
                    SensorData_6 = table.Column<float>(type: "real", nullable: false),
                    SensorData_7 = table.Column<float>(type: "real", nullable: false),
                    SensorData_8 = table.Column<float>(type: "real", nullable: false),
                    SensorData_9 = table.Column<float>(type: "real", nullable: false),
                    SensorData_10 = table.Column<float>(type: "real", nullable: false),
                    SensorData_11 = table.Column<float>(type: "real", nullable: false),
                    SensorData_12 = table.Column<float>(type: "real", nullable: false),
                    SensorData_13 = table.Column<float>(type: "real", nullable: false),
                    SensorData_14 = table.Column<float>(type: "real", nullable: false),
                    SensorData_15 = table.Column<float>(type: "real", nullable: false),
                    SensorData_16 = table.Column<float>(type: "real", nullable: false),
                    SensorData_17 = table.Column<float>(type: "real", nullable: false),
                    SensorData_18 = table.Column<float>(type: "real", nullable: false),
                    SensorData_19 = table.Column<float>(type: "real", nullable: false),
                    SensorData_20 = table.Column<float>(type: "real", nullable: false),
                    SensorData_21 = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FD4TRAINs", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FD1RULs");

            migrationBuilder.DropTable(
                name: "FD1TESTs");

            migrationBuilder.DropTable(
                name: "FD1TRAINs");

            migrationBuilder.DropTable(
                name: "FD2RULs");

            migrationBuilder.DropTable(
                name: "FD2TESTs");

            migrationBuilder.DropTable(
                name: "FD2TRAINs");

            migrationBuilder.DropTable(
                name: "FD3RULs");

            migrationBuilder.DropTable(
                name: "FD3TESTs");

            migrationBuilder.DropTable(
                name: "FD3TRAINs");

            migrationBuilder.DropTable(
                name: "FD4RULs");

            migrationBuilder.DropTable(
                name: "FD4TESTs");

            migrationBuilder.DropTable(
                name: "FD4TRAINs");
        }
    }
}
