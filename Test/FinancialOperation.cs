namespace Test
{
    using System;

    public class FinancialOperation : Operation
    {
        public new const string Category = "financialOperation";

        public FinancialOperation(DateTime dateAndTime, int id) : base(dateAndTime, id)
        {
        }
    }
}