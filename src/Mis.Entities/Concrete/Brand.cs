using Mis.Entities.Concrete.Base;
using System.ComponentModel.DataAnnotations;

namespace Mis.Entities.Concrete
{
    public class Brand: EntityBase
    {
        [Required(ErrorMessage = "Required")]
        [DataType(DataType.Text)]
        [StringLength(50, ErrorMessage = "Field [Brand Name] cannot exceed 50 characters")]
        public string BrandName { get; set; }
    }
}
