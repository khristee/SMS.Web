using Microsoft.AspNetCore.Identity;
namespace SMS.Web.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }    
        public int Age { get; set; }    
        public DateTime Birthdate { get; set; }    
        public string Address { get; set; }    
        public string EnrollmentNo { get; set; }    
        public string FatherName { get; set; }    
        public Gender Gender { get; set; }
        public virtual List<StudentCourse> StudentCourses { get; set; }
        public virtual List<TeacherCourse> TeacherCourses { get; set; }

    }

    public enum Gender
    {
        Male,
        Female,
        Other
    }
}
