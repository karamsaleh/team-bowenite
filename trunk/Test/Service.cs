namespace Test
{
    public abstract class Service : Item
    {
        public Service(string name, string category, decimal salesPrice, decimal discount, decimal value, int code) 
            : base(name, category, salesPrice, value, code, discount)
        {
        }

        public override string Group { get { return "Services"; } }

        public override void Sell()
        {
            // TODO
        }

        public override void Buy()
        {
            // TODO
        }
    }
}