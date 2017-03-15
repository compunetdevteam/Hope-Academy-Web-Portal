using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HopeAcademySMS.Models
{
    public class SubjectCategory
    {
        [Key]
        [DisplayName("Category ID")]
        public int CategoryId { get; set; }

        [DisplayName("Category Name")]
        public string Name { get; set; }

        public virtual ICollection<Subject> Subjects { get; set; }
    }
}