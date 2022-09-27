using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EProject_Sem3.DAL.DataMapping
{
    public class EmpRegister
    {
        [Key]
        public int empNo { get; set; }
        public string designation { get; set; }
        public DateTime joinDate { get; set; }
        public double salary { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string address { get; set; }
        public string contactNo { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public string city { get; set; }
        public string policyStatus { get; set; }
        public int policyId { get; set; }

    }
}
