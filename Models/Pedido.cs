using System.ComponentModel.DataAnnotations;

public class Pedido
{
    public int Id { get; set; }

    public DateTime DataPedido { get; set; }

    [Required]
    public int ClienteId { get; set; }  // ID do Cliente

    [Required]
    public int ProdutoId { get; set; }  // ID do Produto

    [Required]
    public int Quantidade { get; set; }
}
