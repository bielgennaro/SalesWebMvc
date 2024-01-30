using System.ComponentModel;

namespace SalesWebMvc.Models
{
    public class Seller(int id, string name, int identifierCode, string email, double salary, DateTime birthDate)
    {
        public int Id { get; set; } = id;

        [DisplayName("Nome")]
        public string Name { get; set; } = name ?? throw new ArgumentNullException(nameof(name));

        [DisplayName("Código de identificação")]
        public int IdentifierCode { get; set; } = identifierCode;

        [DisplayName("Email")]
        public string Email { get; set; } = email ?? throw new ArgumentNullException(nameof(email));

        [DisplayName("Salário")]
        public double Salary { get; set; } = salary;

        [DisplayName("Data de nascimento")]
        public DateTime BirthDate { get; set; } = birthDate;

        [DisplayName("Departamento")]
        public Department Department { get; set; }

        [DisplayName("Vendas")]
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public void AddSales(SalesRecord record)
        {
            Sales.Add(record);
        }

        public void RemoveSales(SalesRecord record)
        {
            Sales.Remove(record);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sales.Where(s => s.Date >= initial && s.Date <= final).Sum(s => s.Amount);
        }
    }
}
