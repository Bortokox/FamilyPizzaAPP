namespace PizzaAPI.DTOS
{
    public class SuggestedPizzasDto
    {
        public string Name { get; set; }
        public double PrizeForSmall { get; set; }
        public double PrizeForLarge { get; set; }
        public string Ingridients { get; set; }
        public string Description { get; set; }
    }
}