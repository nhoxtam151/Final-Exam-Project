﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Exam_Project.Shared
{
    public class Category
    {
        public int Id { get; set; }

        [MaxLength(255)]
        public string Name { get; set; }
        [MaxLength(500)]
        public string Url { get; set; }

        public string Icon { get; set; }

    
    }
}
