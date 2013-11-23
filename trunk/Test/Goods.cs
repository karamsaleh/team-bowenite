namespace Test
{
    public class Goods : Item
    {
        public Goods(int id, string category, string name, decimal salesPrice, decimal discount, decimal value, string measurement, decimal quantity)
            : base(id, category, name, salesPrice, discount, value)
        {
            this.Measurement = measurement;
            this.Quantity = quantity;
        }

        public string Measurement { get; set; }
        public decimal Quantity { get; set; }

        public override void Sell()
        {
            Stock.RemoveGoods(this);
        }

        public override void Buy()
        {
            Stock.AddGoods(this);
        }

        public override string ToString()
        {
            return string.Format("{0};{1};{2};{3};{4};{5};{6};{7}",
                this.ID, this.Category, this.Name, this.SalesPrice, this.Discount, this.Value, this.Measurement, this.Quantity);
        }
    }
}