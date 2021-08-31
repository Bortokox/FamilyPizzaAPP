namespace PizzaAPI.DTOS
{
    public class PizzaOverwiewDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double PrizeForSmall { get; set; }
        public double PrizeForLarge { get; set; }
        public string Image { get; set; }
    }
}