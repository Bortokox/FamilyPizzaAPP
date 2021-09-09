namespace PizzaAPI.DTOS
{
    public class PizzaDescriptionDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Ingridients { get; set; }
        public string Description { get; set; }
        public int Like { get; set; }
        public int Dislike { get; set; }
    }
}