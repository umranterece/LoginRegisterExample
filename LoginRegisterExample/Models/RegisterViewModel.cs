using System.ComponentModel.DataAnnotations;

namespace LoginRegisterExample.Models
{
    public class RegisterViewModel
    {
        //[Display(Name ="Kullanici Adi", Prompt ="Kullanici adi girinizi")]
        [Required(ErrorMessage = "Username is required!")]
        [StringLength(30, ErrorMessage = "User can be max 30 characters!")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is required!")]
        [MinLength(6, ErrorMessage = "Password can be minimum 6 characters!")]
        [MaxLength(16, ErrorMessage = "Password can be max 16 characters!")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Re-Password is required!")]
        [MinLength(6, ErrorMessage = "Re-Password can be minimum 6 characters!")]
        [MaxLength(16, ErrorMessage = "Re-Password can be max 16 characters!")]
        [Compare(nameof(Password),ErrorMessage ="Re-password is dont be macth password")]
        public string RePassword { get; set; }
    }
}
