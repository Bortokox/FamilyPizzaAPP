using System.Text.Json;

namespace PizzaAPI.Models
{
    public class ErrorDetails
    {
        public string StackTrace { get; set; }
        public string Message { get; set; }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}