﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace QTS_SimpleBilling.Model
{
    public class Catagory
    {
        [Key]
        [MaxLength(20)]
        public int CatagoryId { get; set; }
        [MaxLength(60)]
        public string CatagoryName { get; set; }
       
    }
}
