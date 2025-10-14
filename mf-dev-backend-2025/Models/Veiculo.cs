using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_dev_backend_2025.Models
{
    [Table("veiculos")]
    public class Veiculo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Obrigarório Informar o Nome!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigarório Informar o Placa!")]
        public string Placa { get; set; }

        [Required(ErrorMessage = "Obrigarório Informar o Ano de Fabricação!")]
        public int AnoFabricacao { get; set; }

        [Required(ErrorMessage ="Obrigarório Informar o Ano do Modelo!")]
        public int AnoModelo { get; set; }
    }
}
