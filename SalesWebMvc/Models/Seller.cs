using System.ComponentModel;

namespace SalesWebMvc.Models
{
    public class Seller
    {
        public int Id { get; set; }

        [DisplayName("Nome")]
        public string Name { get; set; }

        [DisplayName("Código de identificação")]
        public int IdentifierCode { get; set; }

        [DisplayName("Email")]
        public string Email { get; set; }

        [DisplayName("Salário")]
        public double Salary { get; set; }

        [DisplayName("Data de nascimento")]
        public DateTime BirthDate { get; set; }

        [DisplayName("Departamento")]
        public Department Department { get; set; }

        [DisplayName("Vendas")]
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller(int id, string name, int identifierCode, string email, double salary, DateTime birthDate, Department department)
        {
            Id = id;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            IdentifierCode = identifierCode;
            Email = email ?? throw new ArgumentNullException(nameof(email));
            Salary = salary;
            BirthDate = birthDate;
            Department = department ?? throw new ArgumentNullException(nameof(department));
        }

        public Seller() { }

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
