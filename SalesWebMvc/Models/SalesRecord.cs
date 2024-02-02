using SalesWebMvc.Models.Enums;

using System.ComponentModel;

namespace SalesWebMvc.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }

        [DisplayName("Data")]
        public DateTime Date { get; set; }

        [DisplayName("Quantidade")]
        public double Amount { get; set; }

        [DisplayName("Status")]
        public SaleStatus Status { get; set; }

        [DisplayName("Vendedor")]
        public Seller Sellers { get; set; }

        public SalesRecord(int id, DateTime date, double amount, SaleStatus status, Seller sellers)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Status = status;
            Sellers = sellers ?? throw new ArgumentNullException(nameof(sellers));
        }

        public SalesRecord() { }
    }
}
