namespace Test
{
    using System;

    public abstract class Operation
    {
        public const string Category = "operation";

        protected Operation(DateTime dateAndTime, int id)
        {
            this.DateAndTime = dateAndTime;
            this.ID = id;
        }

        public DateTime DateAndTime { get; protected set; }
        public int ID { get; protected set; }

        public virtual void Validate() { }
    }
}