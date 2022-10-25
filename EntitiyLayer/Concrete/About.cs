using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Concrete
{
    public class About
    {
        [Key]
        public int aboutId  { get; set; } 
        public string aboutName { get; set; } 
        public string aboutDescription { get; set; }

    }
}
