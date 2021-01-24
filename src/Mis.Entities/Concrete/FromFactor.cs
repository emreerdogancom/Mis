using Mis.Entities.Concrete.Base;
using System.ComponentModel.DataAnnotations;

namespace Mis.Entities.Concrete
{
    public class FromFactor : EntityBase
    {
        [Required(ErrorMessage = "Required")]
        [DataType(DataType.Text)]
        [StringLength(50, ErrorMessage = "Field [From Factor Name] cannot exceed 50 characters")]
        public string FromFactorName { get; set; }
    }
}
