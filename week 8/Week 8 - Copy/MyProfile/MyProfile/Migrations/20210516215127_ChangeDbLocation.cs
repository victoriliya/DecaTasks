using Microsoft.EntityFrameworkCore.Migrations;

namespace MyProfile.Migrations
{
    public partial class ChangeDbLocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SkillShortName",
                table: "Skills",
                type: "TEXT",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 1,
                columns: new[] { "SkillName", "SkillShortName" },
                values: new object[] { "csharp", "C#" });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 2,
                columns: new[] { "SkillName", "SkillShortName" },
                values: new object[] { "NodeJs", "NodeJs" });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 3,
                column: "SkillShortName",
                value: "Chess");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SkillShortName",
                table: "Skills");

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 1,
                column: "SkillName",
                value: "C#");

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 2,
                column: "SkillName",
                value: "Node Js");
        }
    }
}
