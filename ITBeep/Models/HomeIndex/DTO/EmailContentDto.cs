using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITBeep.Models.HomeIndex.DTO
{
    public class EmailContentDto
    {
        public string username { get; set; }
        public string email { get; set; }
        public string mobile { get; set; }
        public string serviceType { get; set; }
        public string schedule { get; set; }
    }
}