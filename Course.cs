namespace okulYonetimSistemi.Models
{
    public class Course
    {
        public int CourseID { get; set; } // Ders ID'si (primary key)
        public string CourseName { get; set; } // Ders Adı
        public int Credits { get; set; } // Kredi
        public string InsturctorID{ get; set; } // Bölüm hocası

        public ICollection<StudentsCourses> StudentCourses { get; set; } = new List<StudentsCourses>();
    }
}
