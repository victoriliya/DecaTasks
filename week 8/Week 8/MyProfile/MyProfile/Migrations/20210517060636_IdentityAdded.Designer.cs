﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyProfile.Data;

namespace MyProfile.Migrations
{
    [DbContext(typeof(MyProfileDbContext))]
    [Migration("20210517060636_IdentityAdded")]
    partial class IdentityAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.6");

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("MyProfile.Models.Event", b =>
                {
                    b.Property<int>("EventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("EventDescription")
                        .HasColumnType("TEXT");

                    b.Property<string>("EventFinishDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("EventName")
                        .HasColumnType("TEXT");

                    b.Property<string>("EventStartDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("ProfileId")
                        .HasColumnType("INTEGER");

                    b.HasKey("EventId");

                    b.HasIndex("ProfileId");

                    b.ToTable("Events");

                    b.HasData(
                        new
                        {
                            EventId = 1,
                            EventDescription = "Lorem ipsum, dolor sit amet consectetur adipisicing elit. At consequatur officia incidunt deserunt vitae delectus quam maiores distinctio omnis cumque dolore vel expedita, tempora ipsum reprehenderit! Repellat quibusdam sint facere?",
                            EventFinishDate = "03 Spetember 2021",
                            EventName = "Code Fest",
                            EventStartDate = "03 August 2019",
                            ProfileId = 1
                        },
                        new
                        {
                            EventId = 2,
                            EventDescription = "Lorem ipsum, dolor sit amet consectetur adipisicing elit. At consequatur officia incidunt deserunt vitae delectus quam maiores distinctio omnis cumque dolore vel expedita, tempora ipsum reprehenderit! Repellat quibusdam sint facere?",
                            EventFinishDate = "03 Spetember 2021",
                            EventName = "C# Meetup",
                            EventStartDate = "03 August 2019",
                            ProfileId = 1
                        },
                        new
                        {
                            EventId = 3,
                            EventDescription = "Lorem ipsum, dolor sit amet consectetur adipisicing elit. At consequatur officia incidunt deserunt vitae delectus quam maiores distinctio omnis cumque dolore vel expedita, tempora ipsum reprehenderit! Repellat quibusdam sint facere?",
                            EventFinishDate = "03 Spetember 2021",
                            EventName = "Chess League",
                            EventStartDate = "03 August 2019",
                            ProfileId = 1
                        });
                });

            modelBuilder.Entity("MyProfile.Models.Profile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Bio")
                        .HasColumnType("TEXT");

                    b.Property<string>("DateOfBirth")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("FacebookLink")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("GitLink")
                        .HasColumnType("TEXT");

                    b.Property<string>("LinkdInLink")
                        .HasColumnType("TEXT");

                    b.Property<string>("OtherName")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProfilePictureUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("SecondtName")
                        .HasColumnType("TEXT");

                    b.Property<string>("TwitterLink")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Profile");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Bio = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quasi cupiditate natus nulla suscipit, quam magni quia laborum assumenda omnis at esse corrupti illum nihil sint in ipsa sit saepe! Delectus!",
                            DateOfBirth = "03 04 1994",
                            Email = "victorbiliya@gmail.com",
                            FacebookLink = "https://facebook.com",
                            FirstName = "Victor",
                            GitLink = "https://git.com",
                            LinkdInLink = "https://linkdIn.com",
                            OtherName = "B.",
                            ProfilePictureUrl = "images/profile.jpg",
                            SecondtName = "Iliya",
                            TwitterLink = "https://twitter.com"
                        });
                });

            modelBuilder.Entity("MyProfile.Models.Project", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProfileId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ProjectCategory")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProjectDemoVideoLink")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProjectDescription")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProjectGitReposiory")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProjectLink")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProjectName")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProjectSnapShop")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProjectStartDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("SkillId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ProjectId");

                    b.HasIndex("ProfileId");

                    b.HasIndex("SkillId");

                    b.ToTable("Projects");

                    b.HasData(
                        new
                        {
                            ProjectId = 1,
                            ProfileId = 1,
                            ProjectCategory = "Desktop App",
                            ProjectDemoVideoLink = "https://youtube.com",
                            ProjectDescription = "Lorem ipsum, dolor sit amet consectetur adipisicing elit. Consectetur, provident magni! Sequi porro quaerat doloribus fugiat dolore accusantium perferendis obcaecati aperiam, aliquid eos possimus corporis iure, facilis totam. Quidem, ipsa?",
                            ProjectGitReposiory = "https://git.com",
                            ProjectLink = "https://git.com",
                            ProjectName = "EDeyPayBank App",
                            ProjectSnapShop = "../images/projectsnapshot1.jpg",
                            ProjectStartDate = "03 April 2021",
                            SkillId = 1
                        },
                        new
                        {
                            ProjectId = 2,
                            ProfileId = 1,
                            ProjectCategory = "Mobile App",
                            ProjectDemoVideoLink = "https://youtube.com",
                            ProjectDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quod eveniet maiores animi repellendus ipsam, in nesciunt obcaecati fugit necessitatibus repudiandae. Quaerat officiis inventore temporibus earum fugit suscipit et veniam? Quia!",
                            ProjectGitReposiory = "https://git.com",
                            ProjectLink = "https://git.com",
                            ProjectName = "Eden Shopping System App",
                            ProjectSnapShop = "../images/projectsnapshot2.jpg",
                            ProjectStartDate = "03 May 2021",
                            SkillId = 2
                        },
                        new
                        {
                            ProjectId = 3,
                            ProfileId = 1,
                            ProjectCategory = "Mobile App",
                            ProjectDescription = "Lorem ipsum, dolor sit amet consectetur adipisicing elit. At consequatur officia incidunt deserunt vitae delectus quam maiores distinctio omnis cumque dolore vel expedita, tempora ipsum reprehenderit! Repellat quibusdam sint facere?",
                            ProjectGitReposiory = "https://git.com",
                            ProjectLink = "https://git.com",
                            ProjectName = "Go There App",
                            ProjectSnapShop = "../images/projectsnapshot3.jpg",
                            ProjectStartDate = "03 August 2019",
                            SkillId = 3
                        },
                        new
                        {
                            ProjectId = 4,
                            ProfileId = 1,
                            ProjectCategory = "Go App",
                            ProjectDescription = "Lorem ipsum, dolor sit amet consectetur adipisicing elit. At consequatur officia incidunt deserunt vitae delectus quam maiores distinctio omnis cumque dolore vel expedita, tempora ipsum reprehenderit! Repellat quibusdam sint facere?",
                            ProjectGitReposiory = "https://git.com",
                            ProjectLink = "https://git.com",
                            ProjectName = "Help",
                            ProjectSnapShop = "../images/projectsnapshot3.jpg",
                            ProjectStartDate = "03 August 2019",
                            SkillId = 3
                        },
                        new
                        {
                            ProjectId = 5,
                            ProfileId = 1,
                            ProjectCategory = "Shipping App",
                            ProjectDescription = "Lorem ipsum, dolor sit amet consectetur adipisicing elit. At consequatur officia incidunt deserunt vitae delectus quam maiores distinctio omnis cumque dolore vel expedita, tempora ipsum reprehenderit! Repellat quibusdam sint facere?",
                            ProjectGitReposiory = "https://git.com",
                            ProjectLink = "https://git.com",
                            ProjectName = "Shipit",
                            ProjectSnapShop = "../images/projectsnapshot3.jpg",
                            ProjectStartDate = "03 August 2019",
                            SkillId = 1
                        });
                });

            modelBuilder.Entity("MyProfile.Models.Skill", b =>
                {
                    b.Property<int>("SkillId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProfileId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SkillCategory")
                        .HasColumnType("TEXT");

                    b.Property<string>("SkillDescription")
                        .HasColumnType("TEXT");

                    b.Property<string>("SkillName")
                        .HasColumnType("TEXT");

                    b.Property<string>("SkillShortName")
                        .HasColumnType("TEXT");

                    b.HasKey("SkillId");

                    b.HasIndex("ProfileId");

                    b.ToTable("Skills");

                    b.HasData(
                        new
                        {
                            SkillId = 1,
                            ProfileId = 1,
                            SkillCategory = "It",
                            SkillDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quod eveniet maiores animi repellendus ipsam, in nesciunt obcaecati fugit necessitatibus repudiandae. Quaerat officiis inventore temporibus earum fugit suscipit et veniam? Quia!",
                            SkillName = "csharp",
                            SkillShortName = "C#"
                        },
                        new
                        {
                            SkillId = 2,
                            ProfileId = 1,
                            SkillCategory = "It",
                            SkillDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quod eveniet maiores animi repellendus ipsam, in nesciunt obcaecati fugit necessitatibus repudiandae. Quaerat officiis inventore temporibus earum fugit suscipit et veniam? Quia!",
                            SkillName = "NodeJs",
                            SkillShortName = "NodeJs"
                        },
                        new
                        {
                            SkillId = 3,
                            ProfileId = 1,
                            SkillCategory = "Sport",
                            SkillDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quod eveniet maiores animi repellendus ipsam, in nesciunt obcaecati fugit necessitatibus repudiandae. Quaerat officiis inventore temporibus earum fugit suscipit et veniam? Quia!",
                            SkillName = "Chess",
                            SkillShortName = "Chess"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MyProfile.Models.Event", b =>
                {
                    b.HasOne("MyProfile.Models.Profile", null)
                        .WithMany("Events")
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MyProfile.Models.Project", b =>
                {
                    b.HasOne("MyProfile.Models.Profile", "Profile")
                        .WithMany("Projects")
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyProfile.Models.Skill", "Skill")
                        .WithMany("Projects")
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Profile");

                    b.Navigation("Skill");
                });

            modelBuilder.Entity("MyProfile.Models.Skill", b =>
                {
                    b.HasOne("MyProfile.Models.Profile", null)
                        .WithMany("Skills")
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MyProfile.Models.Profile", b =>
                {
                    b.Navigation("Events");

                    b.Navigation("Projects");

                    b.Navigation("Skills");
                });

            modelBuilder.Entity("MyProfile.Models.Skill", b =>
                {
                    b.Navigation("Projects");
                });
#pragma warning restore 612, 618
        }
    }
}
