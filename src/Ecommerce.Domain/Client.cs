using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Domain
{
    public class Client
    {
        public int Id { get; set; }

        [DisplayName("Nome")]
        [Required(ErrorMessage = "O campo nome é obrigatório")]
        public string Name { get; set; }

        [DisplayName("E-mail")]
        [Required(ErrorMessage = "O campo e-mail é obrigatório")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DisplayName("Telefone")]
        [Required(ErrorMessage = "O campo telefone é obrigatório")]
        public string Phone { get; set; }
    }
}
