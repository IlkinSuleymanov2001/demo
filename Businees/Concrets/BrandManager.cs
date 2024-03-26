using Businees.Abstracts;
using Businees.Dtos.Request;
using Businees.Dtos.Response;
using DataAccess.Abstracts;
using Entities.Concrets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrets
{
    public class BrandManager : IBrandService
    {

       private readonly IBrandDal  _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        CreatedBrandResponse IBrandService.Get(CreateBrandRequest createBrandRequest)
        {
            Brand brand = new();
            brand.Name = createBrandRequest.Name;
            _brandDal.Add(brand);
            CreatedBrandResponse createdBrandResponse = new CreatedBrandResponse();
            createdBrandResponse.Name = brand.Name;
            createdBrandResponse.Id = 4;
            createdBrandResponse.CreatedTime = DateTime.Now;
            return createdBrandResponse;

        }

        List<GetAllBrandResponse> IBrandService.GetAll()
        {
            List<Brand> brands = _brandDal.GelAll();
            List<GetAllBrandResponse> getAllBrandResponses = new();
            foreach (var brand in brands)
            {
                GetAllBrandResponse allBrandResponse = new GetAllBrandResponse();
                allBrandResponse.Name = brand.Name;
                allBrandResponse.Id = brand.Id;
                allBrandResponse.CreatedTime = allBrandResponse.CreatedTime;
                getAllBrandResponses.Add(allBrandResponse);
            }
            return getAllBrandResponses;
      
        }
    }
}
