using Mis.Entities.Abstract.ViewModel.Base;
using System;

namespace Mis.Entities.Abstract.ViewModel
{
    public interface ITabletViewModel : IViewModel
    {
        int Id { get; set; }

        int ProcessorId { get; set; }
        String ProcessorName { get; set; }


        int BrandId { get; set; }
        String BrandName { get; set; }

        int Quantity { get; set; }
    }
}
