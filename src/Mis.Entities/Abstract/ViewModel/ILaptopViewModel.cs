using Mis.Entities.Abstract.ViewModel.Base;
using System;

namespace Mis.Entities.Abstract.ViewModel
{
    public interface ILaptopViewModel : IViewModel
    {
        int Id { get; set; }

        int ScreenSize { get; set; }
        int UsbPorts { get; set; }

        int ProcessorId { get; set; }
        String ProcessorName { get; set; }


        int BrandId { get; set; }
        String BrandName { get; set; }

        int Quantity { get; set; }
    }
}
