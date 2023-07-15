using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FPTUniversityPE.BusinessObject.Entities
{
    public class User
    {
        public int user_Id { get; set; }
        public string? email_address { get; set; }
        public string? password { get; set; }
        public string? name { get; set; }
        public int RoleId { get; set; }
        public Role? Role { get; set; }
        public ArtWork? ArtWork { get; set; }
        public int artWork_id { get; set; }
    }
}