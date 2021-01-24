using Mis.Entities.Concrete.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mis.Entities.Concrete
{
    public class Tablet : EntityEmptyBase
    {
        [ForeignKey("PCBasedProduct")]
        public int Id { get; set; }

        public PCBasedProduct PCBasedProduct { get; set; }
    }
}
