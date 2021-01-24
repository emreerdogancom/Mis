using Mis.Business.Abstract;
using Mis.Core.Repositories;
using Mis.Entities.Concrete;
using Mis.Entities.Concrete.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Mis.Business.Concrete
{
    public class LaptopManager : ILaptopService
    {
        private ILaptopRepository _ILaptopRepository;

        public LaptopManager(ILaptopRepository LaptopRepository)
        {
            _ILaptopRepository = LaptopRepository;
        }



        public async Task<IEnumerable<Laptop>> GetAllAsync(Expression<Func<Laptop, bool>> filter = null)
        {


            return await _ILaptopRepository.GetAllAsync(filter);
        }

        public IEnumerable<Laptop> GetAll(Expression<Func<Laptop, bool>> filter = null)
        {
            return _ILaptopRepository.GetAll(filter);
        }



        public async Task<Laptop> GetByIdAsync(Expression<Func<Laptop, bool>> filter)
        {


            return await _ILaptopRepository.GetByIdAsync(filter);
        }

        public Laptop GetById(Expression<Func<Laptop, bool>> filter)
        {
            return _ILaptopRepository.GetById(filter);
        }



        public async Task InsertAsync(Laptop entity)
        {
            /* Validation Codes */

            await _ILaptopRepository.InsertAsync(entity);
        }

        public void Insert(Laptop entity)
        {
            _ILaptopRepository.Insert(entity);
        }



        public void Update(Laptop entity)
        {
            _ILaptopRepository.Update(entity);
        }

        public void Delete(Laptop entity)
        {
            _ILaptopRepository.Delete(entity);
        }


        public IEnumerable<LaptopViewModel> GetAllViewModel(Expression<Func<LaptopViewModel, bool>> filter = null)
        {

           return _ILaptopRepository.GetAllViewModel();
        }
    }
}
