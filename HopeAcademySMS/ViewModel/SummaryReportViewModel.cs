using HopeAcademySMS.Models;
using System.Collections.Generic;

namespace HopeAcademySMS.ViewModel
{
    public class SummaryReportViewModel
    {
        public int NoOfStudentPerClass { get; set; }
        public Student Student { get; set; }
        public List<ContinuousAssessment> ContinuousAssessments { get; set; }

        public List<ReportSummary> ReportSummaries { get; set; }
        public List<Result> Results { get; set; }
    }
}