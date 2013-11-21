namespace Test
{
    using System;

    public abstract class Operations
    {
        protected Operations(DateTime dateAndTime, int id)
        {
            this.DateAndTime = dateAndTime;
            this.ID = id;
        }

        public DateTime DateAndTime { get; protected set; }
        public int ID { get; protected set; }
        public virtual string Category { get; }

        public abstract void Validate();
    }
}