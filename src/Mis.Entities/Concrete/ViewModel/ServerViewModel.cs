using Mis.Entities.Abstract.ViewModel;
using System;

namespace Mis.Entities.Concrete.ViewModel
{
    public class ServerViewModel : IServerViewModel
    {
        public int Id { get; set; }

        public int RamSlots { get; set; }
        public int UsbPorts { get; set; }


        public int FromFactorId { get; set; }
        public String FromFactorName { get; set; }


        public int ProcessorId { get; set; }
        public String ProcessorName { get; set; }


        public int BrandId { get; set; }
        public String BrandName { get; set; }

        public int Quantity { get; set; }
    }
}
