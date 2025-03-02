﻿using System.ComponentModel.DataAnnotations;

namespace xolaniStudyGroup.Models
{
	public class StudentModel
	{
        [Display(Name = "STUDENT NUMBER")]
        public string StudentNumber { get; set; }

        [Display(Name = "NAME")]
        public string Name { get; set; }

        [Display(Name = "SURNAME")]
        public string Surname { get; set; }

        [Display(Name = "EMAIL ADDRESS")]
        public string EmailAddress { get; set; }

    }
}