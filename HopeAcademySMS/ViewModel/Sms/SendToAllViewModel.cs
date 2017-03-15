using HopeAcademySMS.Models;
using System.ComponentModel.DataAnnotations;

namespace HopeAcademySMS.ViewModel.Sms
{
    public class SendToAllViewModel
    {
        public PopUp.Term Term { get; set; }

        public string Session { get; set; }

        public string SenderId { get; set; }

        [Display(Name = "Message")]
        [DataType(DataType.MultilineText)]
        public string Message { get; set; }
    }
}