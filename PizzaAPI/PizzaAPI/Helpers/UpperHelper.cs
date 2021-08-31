namespace PizzaAPI.Helpers
{
    public static class UpperHelper
    {
        public static string UppercaseFirst(this string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return string.Empty;
            }
            return char.ToUpper(value[0]) + value.Substring(1);
        }
    }
}