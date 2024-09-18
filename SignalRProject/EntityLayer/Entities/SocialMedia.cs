using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class SocialMedia
    {
        public int SocialMediaID { get; set; }
        public string Title { get; set; }
        public string Url { get; }
        public string Icon { get; }


    }
}
