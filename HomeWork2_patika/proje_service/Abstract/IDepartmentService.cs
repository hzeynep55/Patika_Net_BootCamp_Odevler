using proje_api.Response;
using proje_data.Model;
using proje_dto.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_service.Abstract
{
    public interface IDepartmentService : IBaseService<DepartmentDto, Department>
    {
        
    }
}
