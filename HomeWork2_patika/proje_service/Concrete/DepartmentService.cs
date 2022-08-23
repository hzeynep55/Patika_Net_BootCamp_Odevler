using AutoMapper;
using proje_data.Model;
using proje_data.Repository;
using proje_data.UnitOfWork;
using proje_dto.dto;
using proje_service.Abstract;

namespace proje_service.Concrete
{
    public class DepartmentService:BaseService<DepartmentDto,Department>,IDepartmentService
    {
        public DepartmentService(IDepartmentRepository departmentRepository, IMapper mapper, IUnitOfWork unitOfWork) : base(departmentRepository, mapper, unitOfWork)
        {

        }
    }
}
