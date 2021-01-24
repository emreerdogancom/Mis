using Mis.Entities.Concrete.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mis.Entities.Concrete
{
    public class PCBasedProduct : EntityEmptyBase
    {
        [ForeignKey("Product")]
        public int Id { get; set; }

        public Product Product { get; set; }


        [ForeignKey("Processor")]
        public int ProcessorId { get; set; }
        public Processor Processor { get; set; }

    }
}
