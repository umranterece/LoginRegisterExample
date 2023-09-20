using System.ComponentModel.DataAnnotations;

namespace LoginRegisterExample.Models
{
    public class LoginViewModel
    {
        //[Display(Name ="Kullanici Adi", Prompt ="Kullanici adi girinizi")]
        [Required(ErrorMessage ="Username is required!")]
        [StringLength(30,ErrorMessage ="User can be max 30 characters!")]
        public string UserName { get; set; }

        //[DataType(DataType.Password)]
        [Required(ErrorMessage ="Password is required!")]
        [MinLength(6,ErrorMessage ="Password can be minimum 6 characters!")]
        [MaxLength(16, ErrorMessage ="Password can be max 16 characters!")]
        public string Password { get; set; }
    }
}
