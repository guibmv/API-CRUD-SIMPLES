using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace API_CRUD_.Models
{
    public class Venda
    {
        [Required]
        [Key]
        [DisplayName("Id")]
        [JsonPropertyName("id")]
        public int IDVEN_VEN { get; set; }
        [Required]
        [DisplayName("Cliente")]
        [JsonPropertyName("cliente")]
        public string CLIEN_VEN { get; set; }
        [Required]
        [DisplayName("Vendedor")]
        [JsonPropertyName("vendedor")]
        public string VENDD_VEN { get; set; }
        [Required]
        [DisplayName("MétodoPagamento")]
        [JsonPropertyName("metodoPagamento")]
        public string METPG_VEN { get; set; }
        [Required]
        [DisplayName("QuantidadeParcelas")]
        [JsonPropertyName("quantidadeParcelas")]
        public int PARCV_VEN { get; set; }
        [Required]
        [DisplayName("DataVenda")]
        [JsonPropertyName("dataVenda")]
        public DateTime DTVEN_VEN { get; set; }
    }
}
