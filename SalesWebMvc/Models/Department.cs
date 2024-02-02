using System.ComponentModel;

namespace SalesWebMvc.Models
{
    public class Department
    {
        public int Id { get; set; }

        [DisplayName("Nome")]
        public string Name { get; set; }

        [DisplayName("Código de departamento")]
        public int DepartmentCode { get; set; }

        [DisplayName("Descrição")]
        public string Description { get; set; }

        [DisplayName("Criado em")]
        public DateTime CreatedAt { get; set; }

        [DisplayName("Atualizado em")]
        public DateTime LastUpdatedAt { get; set; }

        [DisplayName("Vendedores")]
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Department(int id, string name, int departmentCode, string description, DateTime createdAt, DateTime lastUpdatedAt)
        {
            Id = id;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            DepartmentCode = departmentCode;
            Description = description ?? throw new ArgumentNullException(nameof(description));
            CreatedAt = createdAt;
            LastUpdatedAt = lastUpdatedAt;
        }

        public void AddSeller(Seller seller)
        {
            Sellers.Add(seller);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sellers.Sum(seller => seller.TotalSales(initial, final));
        }

    }
}
