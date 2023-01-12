using System.ComponentModel.DataAnnotations;

namespace Demo_Product.Models
{
    public class UserLoginModel
    {

    

        [Required(ErrorMessage = "Lutfen Mail alanini doldurun")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lutfen Sifreni Daxil edin")]
        public string Password { get; set; }
    }
}
