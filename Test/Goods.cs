namespace Test
{
    public abstract class Goods : Item
    {
        protected Goods(string name, string measurement, string category, decimal quantity, decimal salesPrice, decimal discount, decimal value, int code)
            : base(name, category, salesPrice, value, code, discount)
        {
            this.Measurement = measurement;
            this.Quantity = quantity;
        }

        public override string Group { get { return "Goods"; } }
        
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