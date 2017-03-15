using HopeAcademySMS.Models;
using System.ComponentModel.DataAnnotations;

namespace HopeAcademySMS.ViewModel
{
    public class GradeViewModel
    {

        public int GradeId { get; set; }

        [Display(Name = "Grade Name")]
        [Required(ErrorMessage = "Grade Name is required")]
        public PopUp.Grade GradeName { get; set; }

        [Display(Name = "Score for Minimum Value")]
        [Range(1, 100)]
        [Required(ErrorMessage = "Minimum Value is required")]
        public int MinimumValue { get; set; }

        [Display(Name = "Score for Maximum Value")]
        [Range(1, 100)]
        [Required(ErrorMessage = "Maximum Value is required")]
        public int MaximumValue { get; set; }


        [Display(Name = "Remark")]
        [Required(ErrorMessage = "Remark is required")]
        public string Remark { get; set; }
    }
}