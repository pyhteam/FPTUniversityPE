using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FPTUniversityPE.BusinessObject.Entities
{
    public class ArtWork
    {

        public int artWork_id { get; set; }
        public string? nameArtWork { get; set; }
        public string? description { get; set; }
        public decimal? price { get; set; }
        public Museums? Museums { get; set; }
        public int museum_id { get; set; }

        public List<User>? Users { get; set; }

    }
}