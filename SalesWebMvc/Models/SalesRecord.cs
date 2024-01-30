using SalesWebMvc.Models.Enums;

using System.ComponentModel;

namespace SalesWebMvc.Models
{
    public class SalesRecord(int id, DateTime date, double amount)
    {
        public int Id { get; set; } = id;

        [DisplayName("Data")]
        public DateTime Date { get; set; } = date;

        [DisplayName("Quantidade")]
        public double Amount { get; set; } = amount;

        [DisplayName("Status")]
        public SaleStatus Status { get; set; }

        [DisplayName("Vendedor")]
        public Seller Sellers { get; set; }
    }
}
