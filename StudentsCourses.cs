namespace okulYonetimSistemi.Models
{
    public class StudentsCourses
    {
        public int SelectionID { get; set; }//ders seçimi piramary key
        public int StudentID { get; set; } // Öğrenci ID'si
        public int CourseID { get; set; } // Ders ID'si

        public Student Student { get; set; } // Navigation property (ilişkili öğrenci)
        public Course Course { get; set; } // Navigation property (ilişkili ders)
        
    }
}
