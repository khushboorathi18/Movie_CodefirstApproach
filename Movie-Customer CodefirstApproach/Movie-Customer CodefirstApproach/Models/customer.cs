using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Movie_Customer_CodefirstApproach.Models
{
    public class customer
    {
        public String FirstName { get; set; }

        public String LastName { get; set; }

        public String Email { get; set; }

        public int phoneno { get; set; }
    }
}
