using Microsoft.EntityFrameworkCore;
using MyProfile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProfile.Data
{
    public class MyProfileDbContext: DbContext
    {
        public MyProfileDbContext(DbContextOptions<MyProfileDbContext> options): base(options)
        {

        }

        public DbSet<Profile> Profile { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Event> Events { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed Profile
            modelBuilder.Entity<Profile>().HasData(new Profile { 
                Id = 1,
                FirstName = "Victor",
                SecondtName = "Iliya",
                OtherName = "B.",
                Email = "victorbiliya@gmail.com",
                DateOfBirth = "03 04 1994",
                ProfilePictureUrl = "images/profile.jpg",
                FacebookLink = "https://facebook.com",
                TwitterLink = "https://twitter.com",
                LinkdInLink = "https://linkdIn.com",
                GitLink = "https://git.com",
                Bio = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quasi cupiditate natus nulla suscipit, quam magni quia laborum assumenda omnis at esse corrupti illum nihil sint in ipsa sit saepe! Delectus!"
            });


            // Seed Projects
            modelBuilder.Entity<Project>().HasData(new Project
            {
                ProjectId = 1,
                ProjectName = "EDeyPayBank App",
                ProjectCategory = "Desktop App",
                ProjectDescription = "Lorem ipsum, dolor sit amet consectetur adipisicing elit. Consectetur, provident magni! Sequi porro quaerat doloribus fugiat dolore accusantium perferendis obcaecati aperiam, aliquid eos possimus corporis iure, facilis totam. Quidem, ipsa?",
                ProjectSnapShop = "../images/projectsnapshot1.jpg",
                ProjectLink = "https://git.com",
                ProjectDemoVideoLink = "https://youtube.com",
                ProjectGitReposiory = "https://git.com",
                ProjectStartDate = "03 April 2021",
                SkillId = 1,
                ProfileId = 1,

            });

            modelBuilder.Entity<Project>().HasData(new Project
            {
                ProjectId = 2,
                ProjectCategory = "Mobile App",
                ProjectName = "Eden Shopping System App",
                ProjectDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quod eveniet maiores animi repellendus ipsam, in nesciunt obcaecati fugit necessitatibus repudiandae. Quaerat officiis inventore temporibus earum fugit suscipit et veniam? Quia!",
                ProjectSnapShop = "../images/projectsnapshot2.jpg",
                ProjectLink = "https://git.com",
                ProjectDemoVideoLink = "https://youtube.com",
                ProjectGitReposiory = "https://git.com",
                ProjectStartDate = "03 May 2021",
                SkillId = 2,
                ProfileId = 1,

            });

            modelBuilder.Entity<Project>().HasData(new Project
            {
                ProjectId = 3,
                ProjectCategory = "Mobile App",
                ProjectName = "Go There App",
                ProjectDescription = "Lorem ipsum, dolor sit amet consectetur adipisicing elit. At consequatur officia incidunt deserunt vitae delectus quam maiores distinctio omnis cumque dolore vel expedita, tempora ipsum reprehenderit! Repellat quibusdam sint facere?",
                ProjectSnapShop = "../images/projectsnapshot3.jpg",
                ProjectLink = "https://git.com",
                ProjectGitReposiory = "https://git.com",
                ProjectStartDate = "03 August 2019",
                SkillId = 3,
                ProfileId = 1,
            });

            modelBuilder.Entity<Project>().HasData(new Project
            {
                ProjectId = 4,
                ProjectCategory = "Go App",
                ProjectName = "Help",
                ProjectDescription = "Lorem ipsum, dolor sit amet consectetur adipisicing elit. At consequatur officia incidunt deserunt vitae delectus quam maiores distinctio omnis cumque dolore vel expedita, tempora ipsum reprehenderit! Repellat quibusdam sint facere?",
                ProjectSnapShop = "../images/projectsnapshot3.jpg",
                ProjectLink = "https://git.com",
                ProjectGitReposiory = "https://git.com",
                ProjectStartDate = "03 August 2019",
                SkillId = 3,
                ProfileId = 1,
            });

            modelBuilder.Entity<Project>().HasData(new Project
            {
                ProjectId = 5,
                ProjectCategory = "Shipping App",
                ProjectName = "Shipit",
                ProjectDescription = "Lorem ipsum, dolor sit amet consectetur adipisicing elit. At consequatur officia incidunt deserunt vitae delectus quam maiores distinctio omnis cumque dolore vel expedita, tempora ipsum reprehenderit! Repellat quibusdam sint facere?",
                ProjectSnapShop = "../images/projectsnapshot3.jpg",
                ProjectLink = "https://git.com",
                ProjectGitReposiory = "https://git.com",
                ProjectStartDate = "03 August 2019",
                SkillId = 1,
                ProfileId = 1,
            });


            // Seed Skills
            modelBuilder.Entity<Skill>().HasData(new Skill
            {
                SkillId = 1, 
                SkillName = "csharp",
                SkillShortName = "C#",
                SkillCategory = "It",
                SkillDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quod eveniet maiores animi repellendus ipsam, in nesciunt obcaecati fugit necessitatibus repudiandae. Quaerat officiis inventore temporibus earum fugit suscipit et veniam? Quia!",
                ProfileId = 1
            });
            modelBuilder.Entity<Skill>().HasData(new Skill
            {
                SkillId = 2,
                SkillName = "NodeJs",
                SkillShortName = "NodeJs",
                SkillCategory = "It",
                SkillDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quod eveniet maiores animi repellendus ipsam, in nesciunt obcaecati fugit necessitatibus repudiandae. Quaerat officiis inventore temporibus earum fugit suscipit et veniam? Quia!",
                ProfileId = 1
            });
            modelBuilder.Entity<Skill>().HasData(new Skill
            {
                SkillId = 3,
                SkillName = "Chess",
                SkillShortName = "Chess",
                SkillCategory = "Sport",
                SkillDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quod eveniet maiores animi repellendus ipsam, in nesciunt obcaecati fugit necessitatibus repudiandae. Quaerat officiis inventore temporibus earum fugit suscipit et veniam? Quia!",
                ProfileId = 1
            });

            // Seed Events
            modelBuilder.Entity<Event>().HasData(new Event
            {
                EventId = 1,
                EventName = "Code Fest",
                EventDescription = "Lorem ipsum, dolor sit amet consectetur adipisicing elit. At consequatur officia incidunt deserunt vitae delectus quam maiores distinctio omnis cumque dolore vel expedita, tempora ipsum reprehenderit! Repellat quibusdam sint facere?",
                EventStartDate = "03 August 2019",
                EventFinishDate = "03 Spetember 2021",
                ProfileId = 1
            });

            modelBuilder.Entity<Event>().HasData(new Event
            {
                EventId = 2,
                EventName = "C# Meetup",
                EventDescription = "Lorem ipsum, dolor sit amet consectetur adipisicing elit. At consequatur officia incidunt deserunt vitae delectus quam maiores distinctio omnis cumque dolore vel expedita, tempora ipsum reprehenderit! Repellat quibusdam sint facere?",
                EventStartDate = "03 August 2019",
                EventFinishDate = "03 Spetember 2021",
                ProfileId = 1
            });

            modelBuilder.Entity<Event>().HasData(new Event
            {
                EventId = 3,
                EventName = "Chess League",
                EventDescription = "Lorem ipsum, dolor sit amet consectetur adipisicing elit. At consequatur officia incidunt deserunt vitae delectus quam maiores distinctio omnis cumque dolore vel expedita, tempora ipsum reprehenderit! Repellat quibusdam sint facere?",
                EventStartDate = "03 August 2019",
                EventFinishDate = "03 Spetember 2021",
                ProfileId = 1
            });
        }

    }
}
