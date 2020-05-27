using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace myQuizapp.Models
{
    public class Question
    {
        public int ID { get; set; }
        [Display(Name = "Question")]
        public string Quest { get; set; }

        [Display(Name = "Right answer")]
        public string RightAnswer { get; set; }
        [Display(Name = "Alternative 1")]
        public string alt1 { get; set; }
        [Display(Name = "Alternative 2")]
        public string alt2 { get; set; }
        [Display(Name = "Alternative 3")]
        public string alt3 { get; set; }
        
    }
}