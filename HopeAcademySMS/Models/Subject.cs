using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HopeAcademySMS.Models
{
    public class Subject
    {

        [Key]
        [Display(Name = "Subject Code")]
        [Required(ErrorMessage = "Suject Code is required")]
        [StringLength(50, ErrorMessage = "Subject CodeYour Address name is too long")]
        public string CourseCode { get; set; }

        [Display(Name = "Subject Name")]
        [Required(ErrorMessage = "Subject Name is required")]
        [StringLength(50, ErrorMessage = "Subject Name is too long")]
        public string CourseName { get; set; }

        [DisplayName("Subject Category")]
        public string CategoriesId { get; set; }

        public virtual SubjectCategory SubjectCategory { get; set; }

        public virtual Student Student { get; set; }

        public virtual ContinuousAssessment ContinuousAssessment { get; set; }

    }
}