using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Issue
    {
        public int Id { get; set; } // Assuming there's an ID for each issue
        public string Location { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; } // Path to the image file
        public string Status { get; set; } // Status of the request (e.g., Open, In Progress, Closed)
    }
}
