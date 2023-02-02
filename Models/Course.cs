namespace SMS.Web.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string CourseCode { get; set; }
        public string Title { get; set; }
        public CourseType TypeofCourse { get; set; }
    }

    public enum CourseType
    {
        Theory,
        practical,
        Both
    }
}
