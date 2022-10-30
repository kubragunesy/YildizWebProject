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
        [StringLength(50)]
        public string projectName { get; set; }
        [StringLength(1000)]
        public string projectDescription { get; set; }
        [StringLength(200)]
        public string projectMediaUrl { get; set; }
        public bool statu { get; set; }
        
        
    }
}
