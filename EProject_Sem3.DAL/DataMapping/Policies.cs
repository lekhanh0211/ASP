using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EProject_Sem3.DAL
{
    public class Policies
    {
        [Key]
        public int policyId { get; set; }
        public string policyName { get; set; }
        public string policyDesc { get; set; }
        public double amount { get; set; }
        public double emi { get; set; }
        public int companyId { get; set; }
        public string medicalId { get; set; }

        [ForeignKey("companyId")]
        public virtual CompanyDetails CompanyDetails { get; set; }
    }
}
