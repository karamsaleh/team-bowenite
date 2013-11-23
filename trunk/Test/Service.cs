namespace Test
{
    public class Service : Item
    {
        public Service(int id, string category, string name, decimal salesPrice, decimal discount, decimal value) 
            : base(id, category, name, salesPrice, discount, value)
        {
        }
    }
}