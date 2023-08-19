using Microsoft.EntityFrameworkCore.Migrations;

namespace MyProfile.Migrations
{
    public partial class AddedItemId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Skills_SkillId",
                table: "Projects");

            migrationBuilder.AlterColumn<int>(
                name: "SkillId",
                table: "Projects",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1,
                column: "SkillId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2,
                column: "SkillId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 3,
                column: "SkillId",
                value: 3);

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "ProfileId", "ProjectCategory", "ProjectDemoVideoLink", "ProjectDescription", "ProjectGitReposiory", "ProjectLink", "ProjectName", "ProjectSnapShop", "ProjectStartDate", "SkillId" },
                values: new object[] { 4, 1, "Go App", null, "Lorem ipsum, dolor sit amet consectetur adipisicing elit. At consequatur officia incidunt deserunt vitae delectus quam maiores distinctio omnis cumque dolore vel expedita, tempora ipsum reprehenderit! Repellat quibusdam sint facere?", "https://git.com", "https://git.com", "Help", "../images/projectsnapshot3.jpg", "03 August 2019", 3 });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "ProfileId", "ProjectCategory", "ProjectDemoVideoLink", "ProjectDescription", "ProjectGitReposiory", "ProjectLink", "ProjectName", "ProjectSnapShop", "ProjectStartDate", "SkillId" },
                values: new object[] { 5, 1, "Shipping App", null, "Lorem ipsum, dolor sit amet consectetur adipisicing elit. At consequatur officia incidunt deserunt vitae delectus quam maiores distinctio omnis cumque dolore vel expedita, tempora ipsum reprehenderit! Repellat quibusdam sint facere?", "https://git.com", "https://git.com", "Shipit", "../images/projectsnapshot3.jpg", "03 August 2019", 1 });

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Skills_SkillId",
                table: "Projects",
                column: "SkillId",
                principalTable: "Skills",
                principalColumn: "SkillId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Skills_SkillId",
                table: "Projects");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 5);

            migrationBuilder.AlterColumn<int>(
                name: "SkillId",
                table: "Projects",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1,
                column: "SkillId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2,
                column: "SkillId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 3,
                column: "SkillId",
                value: null);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Skills_SkillId",
                table: "Projects",
                column: "SkillId",
                principalTable: "Skills",
                principalColumn: "SkillId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
