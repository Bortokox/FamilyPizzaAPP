using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaAPI.Models
{
    public class SuggestedPizzaModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; }
        public double PrizeForSmall { get; set; }
        public double PrizeForLarge { get; set; }
        public string Ingridients { get; set; }
        public string Description { get; set; }
    }
}