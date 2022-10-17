using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IProjectService
    {
        void Insert(Project project);
        void Update(Project project);
        void Remove(Project project);
        List<Project> GetAll();
        Project Get(int id);
    }
}
