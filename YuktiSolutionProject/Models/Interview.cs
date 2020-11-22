using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace YuktiSolutionProject.Models
{
    public enum SkillLevelsEnum : int
    {
        Beginner = 0,
        Intermediate = 1,
        Advanved = 2

    }
    public enum AssessmentModeEnum : int
    {
        Subjective = 0, Objective = 1,Both = 2

    }
    public enum StatusEnum : int
    {
       Draft = 0,
        Published = 1,
        DisContinued = 2

    }


    public class Interview
    {
       [Key]
        public int InterviewId { get; set; }
       
        [Display(Name ="Interview Name")]
        public string  InterviewName { get; set; }
        [Display(Name = "Skill Level")]
        public SkillLevelsEnum SkillLevel { get; set; }
        [Display(Name ="Assessment Mode")]
        public AssessmentModeEnum AssessmentMode { get; set; }
        public StatusEnum  Status { get; set; }


    }
   

}