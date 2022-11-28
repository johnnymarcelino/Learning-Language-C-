
namespace Interface.Services
{
    internal class BrazilTaxService : ITaxService  // não é herança, é realização de interface -> BrazilTaxService implementa a operação na interface
    {
        public double Tax(double amount)
        {
            if (amount <= 100.0)
            {
                return amount * 0.2;
            }
            else
            {
                return amount * 0.15;
            }
        }
    }
}
