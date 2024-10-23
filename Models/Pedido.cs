using System.ComponentModel.DataAnnotations;

public class Pedido
{
    public int Id { get; set; }

    public DateTime DataPedido { get; set; }

    [Required]
    public int ClienteId { get; set; } 

    [Required]
    public int ProdutoId { get; set; } 

    [Required]
    public int Quantidade { get; set; }
}
