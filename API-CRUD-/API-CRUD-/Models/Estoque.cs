using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace API_CRUD_.Models
{
    public class Estoque
    {
        [Required]
        [Key]
        [DisplayName("Id")]
        [JsonPropertyName("id")]
        public int IDEST_EST { get; set; }
        [Required]
        [ForeignKey("IDPRD_PRD")]
        [DisplayName("IdProduto")]
        [JsonPropertyName("idProduto")]
        public int IDPRD_EST { get; set; }
        [Required]
        [DisplayName("Quantidade")]
        [JsonPropertyName("quantidade")]
        public int QTTRE_EST { get; set; }
        [Required]
        [DisplayName("DataAtualização")]
        [JsonPropertyName("dataAtualização")]
        public DateTime ATTET_EST { get; set; }
    }
}
