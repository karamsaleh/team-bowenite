namespace Test
{
    public abstract class Goods : Item
    {
        public new const string Category = "goods";

        protected Goods(string name, string measurement, decimal quantity, decimal salesPrice, decimal discount, decimal value, int code)
            : base(name, salesPrice, value, code, discount)
        {
            this.Measurement = measurement;
            this.Quantity = quantity;
        }
        
        public string Measurement { get; protected set; }

        public decimal Quantity { get; protected set; }

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