namespace Test
{
    public abstract class Service : Item
    {
        public new const string Category = "service";
       
        public Service(int id, string name, decimal salesPrice, decimal discount, decimal value) 
            : base(id, name, salesPrice, discount, value)
        {
        }
    }
}