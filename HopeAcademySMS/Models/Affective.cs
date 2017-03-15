namespace HopeAcademySMS.Models
{
    public class Affective
    {
        public int Id { get; set; }
        public string StudentId { get; set; }
        public string TermName { get; set; }
        public string SessionName { get; set; }
        public string ClassName { get; set; }
        public int Punctuality { get; set; }
        public int BehaviourInClass { get; set; }
        public int AttentivenessInClass { get; set; }
        public int ClassAssignmentsProjects { get; set; }
        public int Neatness { get; set; }
        public int SelfControl { get; set; }
        public int RelationshipWithOthers { get; set; }
        public int RelationshipWithTeachersAndStaff { get; set; }
        public int SenseOfResponsibility { get; set; }
        public int AttendanceInClass { get; set; }
        public int Politeness { get; set; }
        public int HonestyAndReliability { get; set; }
        //public virtual ICollection<R>
    }

    public class Expression
    {

        public int Id { get; set; }
        public string StudentId { get; set; }
        public string TermName { get; set; }
        public string SessionName { get; set; }
        public string ClassName { get; set; }
        public int QualityofHandwriting { get; set; }
        public int GrammaticalSkills { get; set; }
        public int OralExpression { get; set; }
        public int ImaginationCreativity { get; set; }
        public int VocabularyLexicalSkills { get; set; }
        public int OrganizationOfIdeas { get; set; }
    }

    public class OtherSkills
    {
        public int Id { get; set; }
        public string StudentId { get; set; }
        public string TermName { get; set; }
        public string SessionName { get; set; }
        public string ClassName { get; set; }
        public int TeamWorkTeamLeading { get; set; }
        public int PhysicalDexterity { get; set; }
        public int ClubAndSocieties { get; set; }
        public int ArtisticOrMusicalSkills { get; set; }
        public int LabAndWorkshopSkills { get; set; }
        public int Sports { get; set; }
    }

}