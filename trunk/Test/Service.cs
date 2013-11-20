namespace Test
{
    public abstract class Service : Item
    {
        public Service(string category, decimal salesPrice, decimal discount, decimal value, int code) 
            : base(category, salesPrice, value, code, discount)
        {
        }

        public override string Category { get { return "Services"; } }

        public override void Sell()
        {
            // TODO
        }
    }
}