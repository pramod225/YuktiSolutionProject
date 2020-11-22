using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace YuktiSolutionProject.Models
{
  
        public enum skillLevel : int
        {
            Beginner = 0,
            Intermediate = 1,
            Advanved = 2

        }

        public enum AssessmentMode : int
        {
            Subjective = 0,
            Objective = 1,
            Both = 2

        }

        public class SkillGroup
        {


            public int SkillGroupId { get; set; }

            [Display(Name = "Skill Group ")]
            public string SkillGroupName { get; set; }



            [Display(Name = "Skill Level")]

            public skillLevel Skill { get; set; }

            [Display(Name = "Assessment Mode")]
            public AssessmentMode Assmode { get; set; }




        }
    
}