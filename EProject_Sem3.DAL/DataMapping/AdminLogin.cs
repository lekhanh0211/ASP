using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EProject_Sem3.DAL
{
    public class AdminLogin
    {
        [Key]
        public string username { get; set; }
        public string password { get; set; }
    }
}
