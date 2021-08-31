namespace PizzaAPI.Models
{
    public class PizzaModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double PrizeForSmall { get; set; }
        public double PrizeForLarge { get; set; }
        public string Image { get; set; }
        public string Ingridients { get; set; }
        public string Description { get; set; }
        public int Like { get; set; }
        public int Dislike { get; set; }
    }
}