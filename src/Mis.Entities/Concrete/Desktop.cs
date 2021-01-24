using Mis.Entities.Concrete.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mis.Entities.Concrete
{
    public class Desktop : EntityEmptyBase
    {
        [ForeignKey("Computer")]
        public int Id { get; set; }

        public Computer Computer { get; set; }
    }
}
