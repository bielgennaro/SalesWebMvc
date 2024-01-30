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

    }
}
