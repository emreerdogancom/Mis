using Mis.Entities.Concrete.Base;
using System.ComponentModel.DataAnnotations;

namespace Mis.Entities.Concrete
{
    public class Processor : EntityBase
    {
        [Required(ErrorMessage = "Required")]
        [DataType(DataType.Text)]
        [StringLength(50, ErrorMessage = "Field [Processor Name] cannot exceed 50 characters")]
        public string ProcessorName { get; set; }
    }
}
