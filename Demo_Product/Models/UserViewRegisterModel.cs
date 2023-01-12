using System.ComponentModel.DataAnnotations;

namespace Demo_Product.Models
{
    public class UserViewRegisterModel
    {

        [Required(ErrorMessage = "Lutfen ad hissesini bos kecmeyin")]

        public string Name { get; set; }

        [Required(ErrorMessage = "Lutfen soyad hissesini bos kecmeyin")]

        public string SurName { get; set; }

        [Required(ErrorMessage = "Istifadeci adini bos kecmeyin")]
        public string UserNmae { get; set; }

        [Required(ErrorMessage = "Lutfen Mail Daxil Edin")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Lutfen Sifre Giriniz")]
        public  string Password { get; set; }

        [Required(ErrorMessage = "Lutfen sifreyi tekrar daxil edin")]
        public string ConfigrPassword { get; set; }
    }
}
