using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OBDSystemAPP.Models
{
    public class CampaignInfo
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }
        public string Achievement { get; set; }
        public DateTime PublishDate { get; set; }
    }
}