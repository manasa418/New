﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.Models
{
    public class CoverType
    {

        [Key]
        public int CoverTypeId { get; set; }


        [Required]
        [DisplayName("Cover Type")]
        [MaxLength(50)]
        public string CoverTypeName { get; set; }
    }
}
