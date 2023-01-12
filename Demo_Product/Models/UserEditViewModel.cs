using System.ComponentModel.DataAnnotations;

namespace Demo_Product.Models
{
    public class UserEditViewModel
    {


        [Required(ErrorMessage ="Ad Hissesini Bos kecmeyin")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Soyad hissesini bos kece bilmezsiniz")]
        public string SurName { get; set; }

        [Required(ErrorMessage ="Lutfen cinsiyyet secin")]

        public string Gender { get; set; }

        [Required(ErrorMessage ="Lutfen mail alaninini doldurun")]

        public string Mail { get; set; }

        [Required(ErrorMessage ="Lutfen Sifre Daxil Edin")]
        public string Password { get; set; }

        [Required(ErrorMessage ="Lutfen Sifreye Tekrar girin")]

        public string ConfigrmPassword { get; set; }

    }
}
