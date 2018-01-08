using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Web;

namespace OBDSystemAPP.Models
{
    public class AdminInfo
    {
        public int Id { get; set; }
        public string  AdminName { get; set; }
        public string Designation { get; set; }
        public string Photo { get; set; }
        public string Email { get; set; }
        public string AdminId { get; set; }
        public string Passwords { get; set; }
        public DateTime CreatedAt { get; set; } 
    }
}