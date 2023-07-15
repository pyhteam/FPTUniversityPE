using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FPTUniversityPE.BusinessObject.Entities
{
    public class Museums
    {
        public int museum_id { get; set; }
        public string? museum_name { get; set; }
        public string? address { get; set; }

        public List<ArtWork>? ArtWorks { get; set; }
        
    }
}