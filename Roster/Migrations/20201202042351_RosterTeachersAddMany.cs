using Microsoft.EntityFrameworkCore.Migrations;

namespace Roster.Migrations
{
    public partial class RosterTeachersAddMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClassRoom_Teacher_TeacherId",
                table: "ClassRoom");

            migrationBuilder.DropIndex(
                name: "IX_ClassRoom_TeacherId",
                table: "ClassRoom");

            migrationBuilder.DropColumn(
                name: "TeacherId",
                table: "ClassRoom");

            migrationBuilder.AddColumn<int>(
                name: "SchoolId",
                table: "Teacher",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ClassRoomTeacher",
                columns: table => new
                {
                    ClassRoomsClassRoomId = table.Column<int>(type: "integer", nullable: false),
                    TeachersTeacherId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassRoomTeacher", x => new { x.ClassRoomsClassRoomId, x.TeachersTeacherId });
                    table.ForeignKey(
                        name: "FK_ClassRoomTeacher_ClassRoom_ClassRoomsClassRoomId",
                        column: x => x.ClassRoomsClassRoomId,
                        principalTable: "ClassRoom",
                        principalColumn: "ClassRoomId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClassRoomTeacher_Teacher_TeachersTeacherId",
                        column: x => x.TeachersTeacherId,
                        principalTable: "Teacher",
                        principalColumn: "TeacherId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Teacher_SchoolId",
                table: "Teacher",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassRoomTeacher_TeachersTeacherId",
                table: "ClassRoomTeacher",
                column: "TeachersTeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Teacher_School_SchoolId",
                table: "Teacher",
                column: "SchoolId",
                principalTable: "School",
                principalColumn: "SchoolId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teacher_School_SchoolId",
                table: "Teacher");

            migrationBuilder.DropTable(
                name: "ClassRoomTeacher");

            migrationBuilder.DropIndex(
                name: "IX_Teacher_SchoolId",
                table: "Teacher");

            migrationBuilder.DropColumn(
                name: "SchoolId",
                table: "Teacher");

            migrationBuilder.AddColumn<int>(
                name: "TeacherId",
                table: "ClassRoom",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ClassRoom_TeacherId",
                table: "ClassRoom",
                column: "TeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_ClassRoom_Teacher_TeacherId",
                table: "ClassRoom",
                column: "TeacherId",
                principalTable: "Teacher",
                principalColumn: "TeacherId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
