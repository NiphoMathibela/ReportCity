using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class AnnouncementModel
    {
        public DateTime Date { get; set; }
        public string? AnnouncementText { get; set; }
    }
}
