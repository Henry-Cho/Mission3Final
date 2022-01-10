using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace IS413Mission3Final.Models
{
    public class formModel
    {
        //[Required]
        [Range(0, 100)]
        public int homework { get; set; }
        [Range(0, 100)]
        public int gp { get; set; }
        [Range(0, 100)]
        public int quiz { get; set; }
        [Range(0, 100)]
        public int exam { get; set; }
        [Range(0, 100)]
        public int intex { get; set; }
    }

    public class resultModel
    {
        public double total_pct { get; set; }
        public string letter_grade { get; set; }
    }
}
