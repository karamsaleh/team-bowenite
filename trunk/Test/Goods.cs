namespace Test
{
    public class Goods : Item
    {
        public new const string Category = "goods";

        public Goods(int id, string name, decimal salesPrice, decimal discount, decimal value, string measurement, decimal quantity)
            : base(id, name, salesPrice, discount, value)
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
    }
}