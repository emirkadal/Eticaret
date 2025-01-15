using System.ComponentModel.DataAnnotations;

namespace ETicaret.WebUI.Models
{
    public class LoignViewModel
    {
        [DataType(DataType.EmailAddress), Required(ErrorMessage ="E-Mail Boş Bırakılamaz")]
        public string Email { get; set; }
        [Display(Name = "Şifre"), Required(ErrorMessage = "Şifre Boş Bırakılamaz")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string? ReturnUrl { get; set; }
        public bool Rememberme { get; set; }
    }
}
