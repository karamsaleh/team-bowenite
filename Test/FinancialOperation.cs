namespace Test
{
    using System;

    /// <summary>
    /// Defines a financial operation. All warehouse specific financial operations inherit this class.
    /// </summary>
    public abstract class FinancialOperation : Operation
    {
        public new const string Category = "financialOperation";

        /// <summary>
        /// Initializes a new instance of the <see cref="FinancialOperation" /> class.
        /// </summary>
        /// <param name="dateAndTime">The date and time.</param>
        /// <param name="id">The id.</param>
        protected FinancialOperation(DateTime dateAndTime, int id) : base(dateAndTime, id)
        {
        }
    }
}