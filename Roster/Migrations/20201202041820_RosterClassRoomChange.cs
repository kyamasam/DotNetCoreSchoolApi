using Microsoft.EntityFrameworkCore.Migrations;

namespace Roster.Migrations
{
    public partial class RosterClassRoomChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classes_School_SchoolId",
                table: "Classes");

            migrationBuilder.DropForeignKey(
                name: "FK_Classes_Teacher_TeacherId",
                table: "Classes");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Classes_ClassRoomId",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Classes",
                table: "Classes");

            migrationBuilder.RenameTable(
                name: "Classes",
                newName: "ClassRoom");

            migrationBuilder.RenameIndex(
                name: "IX_Classes_TeacherId",
                table: "ClassRoom",
                newName: "IX_ClassRoom_TeacherId");

            migrationBuilder.RenameIndex(
                name: "IX_Classes_SchoolId",
                table: "ClassRoom",
                newName: "IX_ClassRoom_SchoolId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClassRoom",
                table: "ClassRoom",
                column: "ClassRoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_ClassRoom_School_SchoolId",
                table: "ClassRoom",
                column: "SchoolId",
                principalTable: "School",
                principalColumn: "SchoolId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClassRoom_Teacher_TeacherId",
                table: "ClassRoom",
                column: "TeacherId",
                principalTable: "Teacher",
                principalColumn: "TeacherId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_ClassRoom_ClassRoomId",
                table: "Students",
                column: "ClassRoomId",
                principalTable: "ClassRoom",
                principalColumn: "ClassRoomId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClassRoom_School_SchoolId",
                table: "ClassRoom");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassRoom_Teacher_TeacherId",
                table: "ClassRoom");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_ClassRoom_ClassRoomId",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ClassRoom",
                table: "ClassRoom");

            migrationBuilder.RenameTable(
                name: "ClassRoom",
                newName: "Classes");

            migrationBuilder.RenameIndex(
                name: "IX_ClassRoom_TeacherId",
                table: "Classes",
                newName: "IX_Classes_TeacherId");

            migrationBuilder.RenameIndex(
                name: "IX_ClassRoom_SchoolId",
                table: "Classes",
                newName: "IX_Classes_SchoolId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Classes",
                table: "Classes",
                column: "ClassRoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_School_SchoolId",
                table: "Classes",
                column: "SchoolId",
                principalTable: "School",
                principalColumn: "SchoolId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_Teacher_TeacherId",
                table: "Classes",
                column: "TeacherId",
                principalTable: "Teacher",
                principalColumn: "TeacherId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Classes_ClassRoomId",
                table: "Students",
                column: "ClassRoomId",
                principalTable: "Classes",
                principalColumn: "ClassRoomId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
