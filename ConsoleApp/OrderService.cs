namespace ConsoleApp
{
    public class OrderService
    {
        public double CalculatePrice()
        {
            var price = 2000.0;

            if (price > 1000.0)
            {
                return price - 100.0;
            }
            else
            {
                return price;
            }
        }
    }
}