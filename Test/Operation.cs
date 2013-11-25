namespace Test
{
    using System;
    using System.Text;

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

        public override string ToString()
        {
            var operationInfo = new StringBuilder();

            foreach (var property in this.GetType().GetProperties())
            {
                operationInfo.AppendFormat("{0};", property.GetValue(this));
            }

            return operationInfo.ToString();
        }
    }
}