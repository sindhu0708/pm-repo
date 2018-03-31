using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjectManagement.Models
{
    public class Project
    {
        public List<tblProject> projectCollection = new List<tblProject>();

    }

    public class tblProject
    {
        public int ID { get; set; }
        [Display(Name = "Give a good name")]
        public string name { get; set; }
        [Display(Name = "When do you want to start?")]
        public DateTime startDate { get; set; }
        [Display(Name = "When do you want to be completed?")]
        public DateTime dueDate { get; set; }
        [Display(Name = "Explain little more")]
        public string description { get; set; }
        [Display(Name = "What are your expectations and exclusions in this journey?")]
        public string scope { get; set; }
    }
}