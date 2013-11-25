namespace Test
{
    using System;

    public abstract class FinancialOperation : Operation
    {
        public new const string Category = "financialOperation";

        public FinancialOperation(DateTime dateAndTime, int id) : base(dateAndTime, id)
        {
        }
    }
}