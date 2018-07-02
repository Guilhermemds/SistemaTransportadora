using System.ComponentModel.DataAnnotations;

namespace Modelos
{
    public class Motorista
    {
        [Key]
        public int MotoristaID { get; set; }      

        public string Nome { get; set; }

        public string Telefone { get; set; }

        public string Carteira { get; set; }

        public string Cpf { get; set; }

        public bool Ativo { get; set; }
    }
}
