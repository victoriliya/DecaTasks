using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProfile.Models
{

    /// <summary>
    /// Interface to define the contract for project operatoins
    /// </summary>
    public interface IProjectRepository
    {
        IEnumerable<Project> GetProjects { get; set; }

        public Project GetProject(int id);
        public bool CreateProject(Project project);
        public bool UpdateProject(Project project);
        public bool DeleteProject(int projectId);
    }
}
