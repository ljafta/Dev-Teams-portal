using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EndToEnd.Models
{
    public class Groups
    {
        [Key]
        public string Id { get; set; }
        [Display(GroupName = "Group Name")]
        public string GroupName { get; set; }
    }
}