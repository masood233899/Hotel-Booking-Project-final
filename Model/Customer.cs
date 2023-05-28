using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HotelProject.Model
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int customerId { get; set; }
        public string? customerName { get; set; }
        public int customerPhone { get; set; }
        public string? customerAddress { get; set; }


    }
}
