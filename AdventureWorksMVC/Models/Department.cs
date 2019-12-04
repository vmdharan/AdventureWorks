using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AdventureWorks.Models
{
    public class Department
    {
        [Display(Name = "DepartmentID")]
        public short DepartmentID { get; set; }

        [Display(Name = "Department Name")]
        public string Name { get; set; }

        [Display(Name = "Group Name")]
        public string GroupName { get; set; }

        [Display(Name = "Last Modified")]
        public DateTime ModifiedDate { get; set; }
    }
}