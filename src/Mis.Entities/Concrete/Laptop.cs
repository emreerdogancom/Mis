using Mis.Entities.Concrete.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mis.Entities.Concrete
{
    public class Laptop : EntityEmptyBase
    {
        [ForeignKey("PCBasedProduct")]
        public int Id { get; set; }

        public PCBasedProduct PCBasedProduct { get; set; }

        public int ScreenSize { get; set; }
        public int UsbPorts { get; set; }
    }
}
