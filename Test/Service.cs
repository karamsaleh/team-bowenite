namespace Test
{
    public abstract class Service : Item
    {
        public new const string Category = "service";

        public Service(string name, string category, decimal salesPrice, decimal discount, decimal value, int code) 
            : base(name, salesPrice, value, code, discount)
        {
        }

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