using Business.Services.Abstract;
using Core.Utilities.Exceptions;
using DataAccessLayer.Repositories.Abstract;
using Entities.DTOs.Brand;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Services.Concrete
{
    public class BrandService : IBrandService
    {
        private readonly IBrandRepository _brandRepository;

        public BrandService(IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }

        public Task CreateBrand(CreateBrandDto create)
        {
            if (await _brandRepository.IsExistsEntity(ex => ex.Name == create.Name))
            {
                throw new AlreadyExistException("Eyni adli Brand movcuddur");
            }
        }

        public Task<GetBrandDto> GetAllBrands()
        {
            throw new NotImplementedException();
        }

        public Task<GetBrandDto> GetBrandById()
        {
            throw new NotImplementedException();
        }

        public Task<GetBrandDto> GetBrandByName()
        {
            throw new NotImplementedException();
        }

        public Task UpdateBrand(Guid id, UpdateBrandDto update)
        {
            throw new NotImplementedException();
        }
    }
}
