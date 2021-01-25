using Mis.Entities.Abstract.ViewModel;
using System;

namespace Mis.Entities.Concrete.ViewModel
{
    public class LaptopViewModel : IViewModel
    {
        public int Id { get; set; }

        public int ScreenSize { get; set; }
        public int UsbPorts { get; set; }


        public int ProcessorId { get; set; }
        public String ProcessorName { get; set; }


        public int BrandId { get; set; }
        public String BrandName { get; set; }

        public int Quantity { get; set; }
    }
}
