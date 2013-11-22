namespace Test
{
    using System;

    public class Invoice
    {
        public Invoice(ulong invoiceNumber, ulong saleNumber, DateTime invoiceDate, string companyName, decimal totalInvoiceCashValue)
        {
            this.InvoiceNumber = invoiceNumber;
            this.SaleNumber = saleNumber;
            this.InvoiceDate = invoiceDate;
            this.CompanyName = companyName;
            this.TotalInvoiceCashValue = totalInvoiceCashValue;
        }

        public ulong InvoiceNumber { get; private set; }
        public ulong SaleNumber { get; private set; }
        public DateTime InvoiceDate { get; private set; }
        public string CompanyName { get; private set; }
        public decimal TotalInvoiceCashValue { get; private set; }
    }
}