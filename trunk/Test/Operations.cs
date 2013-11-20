namespace Test
{
    using System;

    public abstract class Operations
    {
        public DateTime Date { get; protected set; }
        
        protected Operations(DateTime date)
        {
            this.Date = date;
        }

        public abstract void Validate();
    }
}