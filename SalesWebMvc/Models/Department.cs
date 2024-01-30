using System.ComponentModel;

namespace SalesWebMvc.Models
{
    public class Department(int id, string name, int departmentCode, string description, DateTime createdAt, DateTime lastUpdatedAt)
    {
        public int Id { get; set; } = id;

        [DisplayName("Nome")]
        public string Name { get; set; } = name ?? throw new ArgumentNullException(nameof(name));

        [DisplayName("Código de departamento")]
        public int DepartmentCode { get; set; } = departmentCode;

        [DisplayName("Descrição")]
        public string Description { get; set; } = description ?? throw new ArgumentNullException(nameof(description));

        [DisplayName("Criado em")]
        public DateTime CreatedAt { get; set; } = createdAt;

        [DisplayName("Atualizado em")]
        public DateTime LastUpdatedAt { get; set; } = lastUpdatedAt;

        [DisplayName("Vendedores")]
        public ICollection<Seller> Sellers { get; set;} = new List<Seller>();

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
