using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ORM.Data.Model
{
    public class Country
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public DateTime FoundationDate { get; set; }

        [Required]
        public string GovernmentType { get; set; }

        [Required]
        public string MapLink { get; set; }

        [Required]
        public uint Population { get; set; }

        [Required]
        public uint Area { get; set; }

        [Required]
        public uint GDP { get; set; }

        [Required]
        public string President { get; set; }

        [Required]
        public string Hymn { get; set;}


    }
}
