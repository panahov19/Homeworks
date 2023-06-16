using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ORM_project.Model
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
        public int Population { get; set; }

        [Required]
        public int Area { get; set; }

        [Required]
        public int GDP { get; set; }

    }
}
