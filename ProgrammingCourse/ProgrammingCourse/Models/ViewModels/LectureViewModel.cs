﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProgrammingCourse.Models.ViewModels
{
    public class LectureViewModel
    {
        [Required]
        public int Section { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string VideoUrl { get; set; }

        [Required]
        public int CourseId { get; set; }
    }
}
