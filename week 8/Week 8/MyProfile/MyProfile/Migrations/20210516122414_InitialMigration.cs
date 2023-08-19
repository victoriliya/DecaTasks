using Microsoft.EntityFrameworkCore.Migrations;

namespace MyProfile.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Profile",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    SecondtName = table.Column<string>(type: "TEXT", nullable: true),
                    OtherName = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    DateOfBirth = table.Column<string>(type: "TEXT", nullable: true),
                    ProfilePictureUrl = table.Column<string>(type: "TEXT", nullable: true),
                    FacebookLink = table.Column<string>(type: "TEXT", nullable: true),
                    TwitterLink = table.Column<string>(type: "TEXT", nullable: true),
                    LinkdInLink = table.Column<string>(type: "TEXT", nullable: true),
                    GitLink = table.Column<string>(type: "TEXT", nullable: true),
                    Bio = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profile", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    EventId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EventName = table.Column<string>(type: "TEXT", nullable: true),
                    EventDescription = table.Column<string>(type: "TEXT", nullable: true),
                    EventStartDate = table.Column<string>(type: "TEXT", nullable: true),
                    EventFinishDate = table.Column<string>(type: "TEXT", nullable: true),
                    ProfileId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.EventId);
                    table.ForeignKey(
                        name: "FK_Events_Profile_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "Profile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    SkillId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SkillName = table.Column<string>(type: "TEXT", nullable: true),
                    SkillCategory = table.Column<string>(type: "TEXT", nullable: true),
                    SkillDescription = table.Column<string>(type: "TEXT", nullable: true),
                    ProfileId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.SkillId);
                    table.ForeignKey(
                        name: "FK_Skills_Profile_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "Profile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    ProjectId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProjectName = table.Column<string>(type: "TEXT", nullable: true),
                    ProjectCategory = table.Column<string>(type: "TEXT", nullable: true),
                    ProjectDescription = table.Column<string>(type: "TEXT", nullable: true),
                    ProjectSnapShop = table.Column<string>(type: "TEXT", nullable: true),
                    ProjectLink = table.Column<string>(type: "TEXT", nullable: true),
                    ProjectGitReposiory = table.Column<string>(type: "TEXT", nullable: true),
                    ProjectDemoVideoLink = table.Column<string>(type: "TEXT", nullable: true),
                    ProjectStartDate = table.Column<string>(type: "TEXT", nullable: true),
                    ProfileId = table.Column<int>(type: "INTEGER", nullable: false),
                    SkillId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.ProjectId);
                    table.ForeignKey(
                        name: "FK_Projects_Profile_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "Profile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Projects_Skills_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skills",
                        principalColumn: "SkillId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "EventId", "EventDescription", "EventFinishDate", "EventName", "EventStartDate", "ProfileId" },
                values: new object[] { 1, "Lorem ipsum, dolor sit amet consectetur adipisicing elit. At consequatur officia incidunt deserunt vitae delectus quam maiores distinctio omnis cumque dolore vel expedita, tempora ipsum reprehenderit! Repellat quibusdam sint facere?", "03 Spetember 2021", "Code Fest", "03 August 2019", null });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "EventId", "EventDescription", "EventFinishDate", "EventName", "EventStartDate", "ProfileId" },
                values: new object[] { 2, "Lorem ipsum, dolor sit amet consectetur adipisicing elit. At consequatur officia incidunt deserunt vitae delectus quam maiores distinctio omnis cumque dolore vel expedita, tempora ipsum reprehenderit! Repellat quibusdam sint facere?", "03 Spetember 2021", "C# Meetup", "03 August 2019", null });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "EventId", "EventDescription", "EventFinishDate", "EventName", "EventStartDate", "ProfileId" },
                values: new object[] { 3, "Lorem ipsum, dolor sit amet consectetur adipisicing elit. At consequatur officia incidunt deserunt vitae delectus quam maiores distinctio omnis cumque dolore vel expedita, tempora ipsum reprehenderit! Repellat quibusdam sint facere?", "03 Spetember 2021", "Chess League", "03 August 2019", null });

            migrationBuilder.InsertData(
                table: "Profile",
                columns: new[] { "Id", "Bio", "DateOfBirth", "Email", "FacebookLink", "FirstName", "GitLink", "LinkdInLink", "OtherName", "ProfilePictureUrl", "SecondtName", "TwitterLink" },
                values: new object[] { 1, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quasi cupiditate natus nulla suscipit, quam magni quia laborum assumenda omnis at esse corrupti illum nihil sint in ipsa sit saepe! Delectus!", "03 04 1994", "victorbiliya@gmail.com", "https://facebook.com", "Victor", "https://git.com", "https://linkdIn.com", "B.", "images/profile.jpg", "Iliya", "https://twitter.com" });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "SkillId", "ProfileId", "SkillCategory", "SkillDescription", "SkillName" },
                values: new object[] { 1, null, "It", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quod eveniet maiores animi repellendus ipsam, in nesciunt obcaecati fugit necessitatibus repudiandae. Quaerat officiis inventore temporibus earum fugit suscipit et veniam? Quia!", "C#" });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "SkillId", "ProfileId", "SkillCategory", "SkillDescription", "SkillName" },
                values: new object[] { 2, null, "It", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quod eveniet maiores animi repellendus ipsam, in nesciunt obcaecati fugit necessitatibus repudiandae. Quaerat officiis inventore temporibus earum fugit suscipit et veniam? Quia!", "Node Js" });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "SkillId", "ProfileId", "SkillCategory", "SkillDescription", "SkillName" },
                values: new object[] { 3, null, "Sport", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quod eveniet maiores animi repellendus ipsam, in nesciunt obcaecati fugit necessitatibus repudiandae. Quaerat officiis inventore temporibus earum fugit suscipit et veniam? Quia!", "Chess" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "ProfileId", "ProjectCategory", "ProjectDemoVideoLink", "ProjectDescription", "ProjectGitReposiory", "ProjectLink", "ProjectName", "ProjectSnapShop", "ProjectStartDate", "SkillId" },
                values: new object[] { 1, 1, "Desktop App", "https://youtube.com", "Lorem ipsum, dolor sit amet consectetur adipisicing elit. Consectetur, provident magni! Sequi porro quaerat doloribus fugiat dolore accusantium perferendis obcaecati aperiam, aliquid eos possimus corporis iure, facilis totam. Quidem, ipsa?", "https://git.com", "https://git.com", "EDeyPayBank App", "../images/projectsnapshot1.jpg", "03 April 2021", null });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "ProfileId", "ProjectCategory", "ProjectDemoVideoLink", "ProjectDescription", "ProjectGitReposiory", "ProjectLink", "ProjectName", "ProjectSnapShop", "ProjectStartDate", "SkillId" },
                values: new object[] { 2, 1, "Mobile App", "https://youtube.com", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quod eveniet maiores animi repellendus ipsam, in nesciunt obcaecati fugit necessitatibus repudiandae. Quaerat officiis inventore temporibus earum fugit suscipit et veniam? Quia!", "https://git.com", "https://git.com", "Eden Shopping System App", "../images/projectsnapshot2.jpg", "03 May 2021", null });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "ProfileId", "ProjectCategory", "ProjectDemoVideoLink", "ProjectDescription", "ProjectGitReposiory", "ProjectLink", "ProjectName", "ProjectSnapShop", "ProjectStartDate", "SkillId" },
                values: new object[] { 3, 1, "Mobile App", null, "Lorem ipsum, dolor sit amet consectetur adipisicing elit. At consequatur officia incidunt deserunt vitae delectus quam maiores distinctio omnis cumque dolore vel expedita, tempora ipsum reprehenderit! Repellat quibusdam sint facere?", "https://git.com", "https://git.com", "Go There App", "../images/projectsnapshot3.jpg", "03 August 2019", null });

            migrationBuilder.CreateIndex(
                name: "IX_Events_ProfileId",
                table: "Events",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ProfileId",
                table: "Projects",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_SkillId",
                table: "Projects",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_ProfileId",
                table: "Skills",
                column: "ProfileId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "Profile");
        }
    }
}
