using Mis.Entities.Abstract.ViewModel.Base;
using System;

namespace Mis.Entities.Abstract.ViewModel
{
    public interface IDesktopViewModel : IViewModel
    {
        int Id { get; set; }

        int RamSlots { get; set; }
        int UsbPorts { get; set; }


        int FromFactorId { get; set; }
        String FromFactorName { get; set; }


        int ProcessorId { get; set; }
        String ProcessorName { get; set; }


        int BrandId { get; set; }
        String BrandName { get; set; }

        int Quantity { get; set; }
    }
}
