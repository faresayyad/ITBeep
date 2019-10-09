using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITBeepAngular.Models.Services.DTO
{
    public class EmailDto
    {
        public string username { get; set; }
        public string email { get; set; }
        public string mobile { get; set; }
        public string serviceType { get; set; }
        public string schedule { get; set; }
    }
}
