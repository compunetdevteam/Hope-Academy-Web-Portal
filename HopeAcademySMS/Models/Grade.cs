namespace HopeAcademySMS.Models
{
    public class Grade
    {
        public int GradeId { get; set; }
        public string GradeName { get; set; }
        public int MinimumValue { get; set; }
        public int MaximumValue { get; set; }

        public string Remark { get; set; }
    }
}