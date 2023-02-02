﻿namespace SMS.Web.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string CourseCode { get; set; }
        public string Title { get; set; }
        public CourseType TypeofCourse { get; set; }
        public int BranchId { get; set; }
        public int YearId { get; set; }
        public virtual List<StudentCourse> StudentCourses { get; set; }
        public virtual List<TeacherCourse> TeacherCourses { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual Year year { get; set; }
    }

    public enum CourseType
    {
        Theory,
        practical,
        Both
    }
}
