namespace Test
{
    public abstract class Goods : Item
    {
        protected Goods(string measurement, string category, decimal quantity, decimal salesPrice, decimal discount, decimal value, int code)
            : base(category, salesPrice, value, code, discount)
        {
            this.Measurement = measurement;
            this.Quantity = quantity;
        }

        public override string Category { get { return "Goods"; } }
        
        public string Measurement { get; protected set; }

        public decimal Quantity { get; protected set; }

        public override void Sell()
        {
            // TODO
        }
    }
}