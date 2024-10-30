﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.Concrete
{
    public class Image
    {
        [Key]
        public int ImageId { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
    }
}
