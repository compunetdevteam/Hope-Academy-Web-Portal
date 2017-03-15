using System.Linq;

namespace HopeAcademySMS.Models
{
    public class GradeRemark
    {
        ApplicationDbContext db = new ApplicationDbContext();

        // This can be private now
        public string Grading(double summaryTotal)
        {
            string gradeValue = "";
            int mySummaryTotal = (int)summaryTotal;

            var myGrade = db.Grades.ToList();
            foreach (var item in myGrade)
            {
                if (mySummaryTotal <= item.MaximumValue && mySummaryTotal >= item.MinimumValue)
                {
                    gradeValue = item.GradeName;
                }

            }
            return !string.IsNullOrEmpty(gradeValue) ? gradeValue : "Enter Value between 1 - 100";
            // return gradeValue;
            #region commented Code
            //if (mySummaryTotal <= 100 && mySummaryTotal >= 95)
            //{
            //    return "A1";
            //}
            //else if (mySummaryTotal <= 94 && mySummaryTotal >= 90)
            //{
            //    return "B2";
            //}
            //else if (mySummaryTotal <= 89 && mySummaryTotal >= 85)
            //{
            //    return "B3";
            //}
            //else if (mySummaryTotal <= 84 && mySummaryTotal >= 80)
            //{
            //    return "C4";
            //}
            //else if (mySummaryTotal <= 79 && mySummaryTotal >= 70)
            //{
            //    return "C5";
            //}
            //else if (mySummaryTotal <= 69 && mySummaryTotal >= 60)
            //{
            //    return "C6";
            //}
            //else if (mySummaryTotal <= 59 && mySummaryTotal >= 55)
            //{
            //    return "D7";
            //}
            //else if (mySummaryTotal <= 54 && mySummaryTotal >= 50)
            //{
            //    return "E8";
            //}
            //else if (mySummaryTotal <= 49 && mySummaryTotal >= 0)
            //{
            //    return "F9";
            //}
            //else
            //{
            //    return "Enter the Value between 0 - 100";
            //} 
            #endregion
        }

        // This can be private now
        public string Remark(double summaryTotal)
        {
            string remarkValue = "";

            int mySummaryTotal = (int)summaryTotal;
            var myGrade = db.Grades.ToList();
            foreach (var item in myGrade)
            {
                if (mySummaryTotal <= item.MaximumValue && mySummaryTotal >= item.MinimumValue)
                {
                    remarkValue = item.Remark;
                }
            }

            return !string.IsNullOrEmpty(remarkValue) ? remarkValue : "Enter Value between 1 - 100";



            #region Commented Code
            //if (mySummaryTotal <= 100 && mySummaryTotal >= 95)
            //{
            //    return "Excellent";
            //}
            //else if (mySummaryTotal <= 94 && mySummaryTotal >= 90)
            //{
            //    return "Very Good";
            //}
            //else if (mySummaryTotal <= 89 && mySummaryTotal >= 85)
            //{
            //    return "Good";
            //}
            //else if (mySummaryTotal <= 84 && mySummaryTotal >= 80)
            //{
            //    return "Upper Credit";
            //}
            //else if (mySummaryTotal <= 79 && mySummaryTotal >= 70)
            //{
            //    return "Credit";
            //}
            //else if (mySummaryTotal <= 69 && mySummaryTotal >= 60)
            //{
            //    return "Lower Credit";
            //}
            //else if (mySummaryTotal <= 59 && mySummaryTotal >= 55)
            //{
            //    return "Pass";
            //}
            //else if (mySummaryTotal <= 54 && mySummaryTotal >= 50)
            //{
            //    return "Fair";
            //}
            //else if (mySummaryTotal <= 49 && mySummaryTotal >= 0)
            //{
            //    return "Fail";
            //}
            //else
            //{
            //    return "Enter the Value between 0 - 100";
            //} 
            #endregion
        }

        //public void GetGrading(double gradeValue)
        //{
        //    Grading(gradeValue);
        //}

        //public void GetRemark(double gradeValue)
        //{
        //    Remark(gradeValue);
        //}
    }
}
