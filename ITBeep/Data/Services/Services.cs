using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ITBeep.Data.Services
{
    [Table("Services")]
    public class Services
    {
        public int Id { get; set; }
        [Required]
        public string ServiceName { get; set; }
    }
}