namespace SMS.Web.Models
{
    public class TeacherCourse
    {
        public int ApplicationUserId { get; set; }
        public int CourseId { get; set; }
        public virtual ApplicationUser Teacher { get; set; }
        public virtual Course Course { get; set; }
    }
}
