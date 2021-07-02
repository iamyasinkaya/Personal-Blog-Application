using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace www.yasinkaya.org.Entities.Dtos
{
    public class EmailSendDto
    {
        [DisplayName("Ad ve Soyad")]
        [Required(ErrorMessage ="{0} alanı zorunludur.")]
        [MaxLength(50,ErrorMessage ="{0} alanı en fazla {1} karakterden oluşmalıdır.")]
        [MinLength(5, ErrorMessage = "{0} alanı en az {1} karakterden oluşmalıdır.")]
        [DataType(DataType.Text)]
        public string Name { get; set; }
        [DisplayName("E-posta")]
        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        [MaxLength(100, ErrorMessage = "{0} alanı en fazla {1} karakterden oluşmalıdır.")]
        [MinLength(10, ErrorMessage = "{0} alanı en az {1} karakterden oluşmalıdır.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DisplayName("Ad ve Soyad")]
        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        [MaxLength(125, ErrorMessage = "{0} alanı en fazla {1} karakterden oluşmalıdır.")]
        [MinLength(5, ErrorMessage = "{0} alanı en az {1} karakterden oluşmalıdır.")]
        [DataType(DataType.Text)]
        public string Subject { get; set; }
        [DisplayName("Ad ve Soyad")]
        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        [MaxLength(2500, ErrorMessage = "{0} alanı en fazla {1} karakterden oluşmalıdır.")]
        [MinLength(20, ErrorMessage = "{0} alanı en az {1} karakterden oluşmalıdır.")]
        [DataType(DataType.MultilineText)]
        public string Message { get; set; }
    }
}
