using System.ComponentModel.DataAnnotations;

namespace HopeAcademySMS.Models
{
    public class SMS
    {
        public string Numbers { get; set; }

        public string SenderId { get; set; }

        [Display(Name = "Message")]
        [DataType(DataType.MultilineText)]
        public string Message { get; set; }
    }
}