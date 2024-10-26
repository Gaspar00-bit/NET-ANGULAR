namespace MarketplaceApi.Modelos
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public int CategoriaId { get; set; }
        public int ProducerId { get; set; }

        public Producer Producer { get; set; }
        public Category Categoria { get; set; }
    }
}
