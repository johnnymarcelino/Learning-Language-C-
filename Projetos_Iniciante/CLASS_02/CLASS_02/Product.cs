using System.Globalization;

namespace CLASS_02 {
    internal class Product {
        public string Name;
        public double Price;
        public int Quantity;

        public double ValorTotalEmEstoque() {
            return Quantity * Price;
        }

        public void AddProducts(int quantity) {
            Quantity += quantity;
        }
        public void RemoveProducts(int quantity) {
            Quantity -= quantity;
        }

        public override string ToString() { 
            return Name + ", $" + Price.ToString("F2", CultureInfo.InvariantCulture) + ", " + Quantity
                + " unidades, Total: $ " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
