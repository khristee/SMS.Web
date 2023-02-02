namespace SMS.Web.Models
{
    public class Year
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Course> Courses { get; set; }
    }
}
    