using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ProjectManager : IProjectService
    {
        IProjectDal _projectdal;
        public ProjectManager(IProjectDal projectdal)
        {
            _projectdal = projectdal;
        }

        public Project Get(int id)
        {
            return _projectdal.GetById(b => b.projectId == id);
        }

        public List<Project> GetAll()
        {
            return _projectdal.GetList();
        }

        public void Insert(Project project)
        {
            _projectdal.Insert(project);
        }

        public void Remove(Project project)
        {
            _projectdal.Remove(project);
        }

        public void Update(Project project)
        {
            _projectdal.Update(project);
        }
    }
}
