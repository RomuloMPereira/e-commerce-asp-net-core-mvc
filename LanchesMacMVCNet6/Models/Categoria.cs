using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesMacMVCNet6.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }
     
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Informe o nome da categoria")]
        [StringLength(100, ErrorMessage = "O tamanho máximo é 100 caracteres")]
        public string CategoriaNome { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "Informe a descrição da categoria")]
        [StringLength(200, ErrorMessage = "O tamanho máximo é 200 caracteres")]
        public string Descricao { get; set; }
        public virtual List<Lanche> Lanches { get; set; }
    }
}
