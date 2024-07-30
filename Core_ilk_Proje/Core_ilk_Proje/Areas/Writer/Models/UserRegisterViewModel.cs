using System.ComponentModel.DataAnnotations;

namespace Core_ilk_Proje.Areas.Writer.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen Adınızı Giriniz")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Lütfen Soyadınızı Giriniz")]
        public string Surname { get; set; }
        [Required(ErrorMessage ="Lütfen Kullanıcı Adınızı Giriniz")]
        public string ImageUrl { get; set; }
        [Required(ErrorMessage = "Lütfen Resim URL Giriniz")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Lütfen Şifrenizi Giriniz")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Lütfen Şifrenizi Tekrar Giriniz")]
        [Compare("Password",ErrorMessage ="Şifreler Uyumlu Değil")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Lütfen Mail Adresinizi Giriniz")]
        public string Mail { get; set; }
    }
}
