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
        [StringLength(100)]
        public string aboutName { get; set; }
        [StringLength(1000)]
        public string aboutDescription { get; set; }

    }
}
