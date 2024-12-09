namespace okulYonetimSistemi.Models
{
    public class Users
    {
        public int AdminID { get; set; } // Admin ID'si (primary key)
        public string Username { get; set; } // Admin Kullanıcı Adı
        public string Password { get; set; } // Admin Şifresi
        public string Role { get; set; }
        public int RelatedID {  get; set; }
        public string Email {  get; set; }
    }
}
