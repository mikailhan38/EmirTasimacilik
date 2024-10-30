using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.Concrete
{
    public class TransportService
    {
        [Key]
        public int TransportServiceId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
