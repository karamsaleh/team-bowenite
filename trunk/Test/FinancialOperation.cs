namespace Test
{
    using System;

    public class FinancialOperation : Operation
    {
        public new const string Category = "financialOperation";

        public FinancialOperation(DateTime dateAndTime, int id) : base(dateAndTime, id)
        {
        }

        public override void Validate()
        {
            //throw new NotImplementedException();
        }

        //public static void Sell(Item item)
        //{
        //    item.Sell();

        //    Treasury.Turnover += item.FinalPrice;
        //    Treasury.Profit += (item.FinalPrice - item.Value);
        //}

        //public static void Buy(Item item)
        //{
        //    item.Buy();

        //    Treasury.Turnover -= item.Value;
        //}
    }
}