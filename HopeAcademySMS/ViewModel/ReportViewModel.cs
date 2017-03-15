using HopeAcademySMS.Models;
using System.Collections.Generic;

namespace HopeAcademySMS.ViewModel
{
    public class ReportViewModel
    {
        public int NoOfStudentPerClass { get; set; }
        public int AggregatePosition { get; set; }
        public double Average { get; set; }
        public double TotalScore { get; set; }
        public Student Student { get; set; }
        public OtherSkills OtherSkills { get; set; }
        public List<ContinuousAssessment> Maths { get; set; }
        public List<ContinuousAssessment> English { get; set; }
        public List<ContinuousAssessment> ContinuousAssessments { get; set; }
        public List<Result> Results { get; set; }
    }
}