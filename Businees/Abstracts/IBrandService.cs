using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Businees.Dtos.Response;
using Businees.Dtos.Request;
using Entities.Concrets;


namespace Businees.Abstracts
{
    public interface  IBrandService
    {
        CreatedBrandResponse Get(CreateBrandRequest createBrandRequest);
        List<GetAllBrandResponse> GetAll();

    }
}
