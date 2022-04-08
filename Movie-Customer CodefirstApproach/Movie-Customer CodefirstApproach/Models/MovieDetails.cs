using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Movie_Customer_CodefirstApproach.Models
{
    public class MovieDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MovieId { get; set; }
        public String MovieName { get; set; }

        public int MovieCount { get; set; }

        public String MovieType { get; set; }

        public DateTime MovieDate{ get; set; }
        public int MoviePrice{ get; set; }


    }
}
