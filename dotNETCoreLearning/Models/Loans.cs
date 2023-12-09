using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace dotNETCoreLearning.Models
{
    [Table("Loans")]
    public class Loan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("IdBook")]
        public virtual Book? NavBook { get; set; }
        
        [ForeignKey("IdCustomer")]
        public virtual Book? NavCustomer { get; set; }
    } 
}
