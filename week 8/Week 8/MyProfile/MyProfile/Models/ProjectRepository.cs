using MyProfile.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProfile.Models
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly MyProfileDbContext _myProfileDbContext;
        public ProjectRepository(MyProfileDbContext myProfileDbContext)
        {
            _myProfileDbContext = myProfileDbContext;
        }

        public IEnumerable<Project> GetProjects { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool CreateProject(Project project)
        {
            throw new NotImplementedException();
        }

        public bool DeleteProject(int projectId)
        {
            throw new NotImplementedException();
        }

        public Project GetProject(int id)
        {
            return _myProfileDbContext.Projects.Where(x => x.ProfileId == id).FirstOrDefault();
        }

        public bool UpdateProject(Project project)
        {

            var newProject = GetProject(project.ProjectId);

            if (newProject != null)
            {
                newProject.ProjectName = project.ProjectName;
                newProject.ProjectCategory = project.ProjectCategory;
                newProject.ProjectDescription = project.ProjectDescription;
                newProject.ProjectSnapShop = project.ProjectSnapShop;
                newProject.ProjectLink = project.ProjectLink;
                newProject.ProjectGitReposiory = project.ProjectGitReposiory;
                newProject.ProjectDemoVideoLink = project.ProjectDemoVideoLink;
                newProject.ProjectStartDate = project.ProjectStartDate;
             

                if (_myProfileDbContext.SaveChanges() > 0)
                {
                    return true;
                }
            }
            return false;

        }
    }
}
