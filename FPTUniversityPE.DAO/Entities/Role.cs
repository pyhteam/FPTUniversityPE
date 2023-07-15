using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FPTUniversityPE.BusinessObject.Entities
{
    public class Role
    {
        public int role_id { get; set; }
        public string? role_desc { get; set; }
        public List<User>? Users { get; set; }
    }
}