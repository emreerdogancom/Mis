using Mis.Entities.Concrete.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mis.Entities.Concrete
{
    public class Computer : EntityEmptyBase
    {
        [ForeignKey("PCBasedProduct")]
        public int Id { get; set; }

        public PCBasedProduct PCBasedProduct { get; set; }

        public int RamSlots { get; set; }
        public int UsbPorts { get; set; }


        [ForeignKey("FromFactor")]
        public int FromFactorId { get; set; }
        public FromFactor FromFactor { get; set; }

    }

}
