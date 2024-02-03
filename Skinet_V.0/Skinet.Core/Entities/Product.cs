using System.ComponentModel.DataAnnotations;

namespace Skinet.Core.Entities
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
