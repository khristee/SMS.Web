namespace SMS.Web.Models
{
    public class StudentCourse
    {
        public int Id { get; set; }
        public string Note { get; set; }
        public string ApplicationUserId { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public int CourseId { get; set; }
    }
}
