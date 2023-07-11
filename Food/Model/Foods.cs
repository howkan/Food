using System.ComponentModel.DataAnnotations;

namespace Food.Model
{
    public class Foods
    {
        [Key]
        public int FoodId { get; set; }

        public string? Name { get; set; }

        public string? Description { get; set; }

    }
}
