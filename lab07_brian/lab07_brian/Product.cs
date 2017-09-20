namespace lab07_brian
{
    class Product
    {
        public ProductList CatList { get; set; }
    }
    enum ProductList : int
    {
        Catnip,
        Fish,
        Yarn,
        Ball,
        Human,
        Blanket,
        Caviar
    }
}
