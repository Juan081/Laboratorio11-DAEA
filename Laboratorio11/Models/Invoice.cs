namespace Laboratorio11.Models
{
    public class Invoice
    {
        public int InvoiceID { get; set; }

        public DateTime InvoiceName { get; set;}

        public string InvoiceNumber { get; set;}

        
        public float Total {  get; set;}

        public int CustomerID { get; set;}
        public Customer Customer { get; set;}

    }
}
