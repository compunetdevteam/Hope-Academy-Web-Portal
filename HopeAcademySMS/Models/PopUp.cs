﻿namespace HopeAcademySMS.Models
{
    public class PopUp
    {
        public enum Salutation
        {
            Dr = 1, Nurse, Mr, Mrs, Miss, Engr, Pastor
        }
        public enum Relationship
        {
            Father = 1, Mother, Sister, Brother, Friend, Others
        }
        public enum Gender
        {
            Male = 1, Female
        }
        public enum PMode
        {
            Cash = 1, Cheque, Teller
        }
        public enum Status
        {
            GivenOut = 1, Returned
        }

        public enum Term
        {
            First = 1, Second, Third
        }
        public enum ClassType
        {
            Science = 1, Commercial, Art, A, B, C
        }
        public enum Maritalstatus
        {
            Single = 1, Married, Divorced
        }

        public enum Qualifications
        {
            SSCE,
            NCE,
            OND,
            HND,
            Degree,
            Masters
        }


        public enum State
        {
            Abia, Adamawa, AkwaIbom, Anambra, Bauchi, Bayelsa, Benue, Borno, CrossRiver, Delta, Ebonyi, Edo, Ekiti,
            Abuja, Gombe, Imo, Jigawa, Kaduna, Kano, Katsina, Kebbi, Kogi, Kwara, Lagos, Nasarawa, Niger, Ogun, Ondo, Osun,
            Oyo, Plateau, Rivers, Sokoto, Taraba, Yobe, Zamfara
        }

        public enum Grade
        {
            A1 = 1, B2, B3, C4, C5, C6, D7, E8, F9
        }

        public enum SchoolName
        {
            JSS = 1, SS, PRY, KG
        }

        //public enum ContactGroup
        //{
        //    JSS1 = 1, JSS2, JSS3, SS1, SS2, SS3, Staffs, FormTeacher, All_Student, Past_Students
        //}
    }
}