namespace okulYonetimSistemi.Models
{
    public class Instructor
    {
        public int InstructorID { get; set; } // akademisyen ID'si (primary key)
        public string FirstName { get; set; } // akademsiyen Adı
        public string LastName { get; set; } // akademisyen Soyadı
        public string Email { get; set; } // akademsisyen E-posta Adresi
        public string Department { get; set; } //akademisyen Bölüm
        public string Password { get; set; } // Şifre 

        public ICollection<Student> Students { get; set; } // Danışmana bağlı öğrenciler
    }
}
