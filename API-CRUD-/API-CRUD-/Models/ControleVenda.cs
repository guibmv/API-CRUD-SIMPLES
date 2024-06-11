using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace API_CRUD_.Models
{
    public class ControleVenda
    {
        [Required]
        [Key]
        [DisplayName("Id")]
        [JsonPropertyName("id")]
        public int IDVEE_VEE { get; set; }
        [Required]
        [ForeignKey("IDPRD_PRD")]
        [DisplayName("IdProduto")]
        [JsonPropertyName("idProduto")]
        public int IDPRD_VEE { get; set; }
        [Required]
        [ForeignKey("IDVEN_VEN")]
        [DisplayName("IdVenda")]
        [JsonPropertyName("idVenda")]
        public int IDVEN_VEE { get; set; }
    }
}
