using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Concrete
{
    public class Media
    {
        [Key]
        public int mediaId { get; set; }
        public string mediaName { get; set; }
        ICollection<Project> projects { get; set; }
    }
}
