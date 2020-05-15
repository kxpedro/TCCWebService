using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebService.Models
{
    public class AppUser
    {
        [Key]
        public int AppUserID { get; set; }
        public string AppUsername { get; set; }
        public string AppPassword { get; set; }

    }
}
