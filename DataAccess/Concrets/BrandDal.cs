using DataAccess.Abstracts;
using Entities.Concrets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrets
{
    public  class BrandDal: IBrandDal
    {

        List<Brand> _brands;

        public BrandDal() { 
            _brands = new List<Brand>();
            _brands.Add(new Brand
            {
                Id = 1,
                Name = "bmw",
                CreatedTime = DateTime.Now
            }); _brands.Add(new Brand
            {
                Id = 2,
                Name = "mercedes",
                CreatedTime = DateTime.Now
            }); _brands.Add(new Brand
            {
                Id = 3,
                Name = "bmw2",
                CreatedTime = DateTime.Now
            });

        }
        public void Add(Brand brand)
        {
           _brands.Add(brand);
        }

        public List<Brand> GelAll()
        {
           return _brands;
        }
    }
}
