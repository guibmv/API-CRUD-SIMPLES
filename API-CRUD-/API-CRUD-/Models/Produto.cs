using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace API_CRUD_.Models
{
    public class Produto
    {
        [Required]
        [Key]
        [DisplayName("Id")]
        [JsonPropertyName("id")]
        public int IDPRD_PRD { get; set; }
        [Required]
        [DisplayName("Name")]
        [JsonPropertyName("name")]
        public string NOMPR_PRD { get; set; }
        [Required]
        [DisplayName("Color")]
        [JsonPropertyName("color")]
        public string COLOR_PRD { get; set; }
        [Required]
        [DisplayName("Marca")]
        [JsonPropertyName("marca")]
        public string MARCA_PRD { get; set; }
        [Required]
        [DisplayName("Preço")]
        [JsonPropertyName("preco")]
        public int PRECO_PRD { get; set; }
        [DisplayName("Garantia")]
        [JsonPropertyName("garantia")]
        public string GARAN_PRD { get; set; }
    }
}
