namespace Test
{
    using System;
    using System.Runtime.Serialization;

    public class ItemNotOnStockException : ApplicationException
    {
        public ItemNotOnStockException()
        {
        }

        public ItemNotOnStockException(string message)
            : base(message)
        {
        }

        public ItemNotOnStockException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        public ItemNotOnStockException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}