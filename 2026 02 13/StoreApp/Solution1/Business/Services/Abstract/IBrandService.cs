using Entities.DTOs.Brand;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Services.Abstract
{
    public interface IBrandService
    {
        public Task<GetBrandDto> GetAllBrands();
        public Task<GetBrandDto> GetBrandByName();
        public Task<GetBrandDto> GetBrandById();
        public Task CreateBrand(CreateBrandDto create);
        public Task UpdateBrand(Guid id, UpdateBrandDto update);
    }
}
