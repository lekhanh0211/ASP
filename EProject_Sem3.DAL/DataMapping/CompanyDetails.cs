using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EProject_Sem3.DAL
{
    public class CompanyDetails
    {
        [Key]
        public int companyId { get; set; }
        public string companyName { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public string companyUrl { get; set; }

        public ICollection<Policies> Policies { get; set; }
    }
}
