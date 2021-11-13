using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolio
{
    public class ProjectStorage
    {
        public static List<Project> Projects { get; private set; } = new List<Project>
        {
            new Project
            {
                Name = "КинокрадHD",
                Link = "https://github.com/Zilya23/KinokradHD",
                Description = "No description"
            }
        };
        public static void Add(Project project)
        {
            Projects.Add(project);
        }
        public static void RemoveByName(string name)
        {
            Projects.RemoveAll(p => p.Name == name);
        }
    }
}
