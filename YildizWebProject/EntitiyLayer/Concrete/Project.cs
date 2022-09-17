using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Concrete
{
    public class Project
    {
        [Key]
        public int projectId { get; set; }
        public string projectName { get; set; }
        public string projectDescription { get; set; }
        public int mediaId { get; set; }
        public virtual Media media { get; set; }

    }
}
