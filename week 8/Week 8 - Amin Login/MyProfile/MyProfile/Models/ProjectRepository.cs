using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProfile.Models
{
    public class ProjectRepository : IProjectRepository
    {
        public IEnumerable<Project> GetProjects { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool CreateProject(Project project)
        {
            throw new NotImplementedException();
        }

        public bool DeleteProject(int projectId)
        {
            throw new NotImplementedException();
        }

        public bool UpdateProject(int projectId)
        {
            throw new NotImplementedException();
        }
    }
}
