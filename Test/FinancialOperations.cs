namespace Test
{
    using System;

    public class FinancialOperations : Operations
    {
        public FinancialOperations(DateTime date) : base(date)
        {
        }

        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}