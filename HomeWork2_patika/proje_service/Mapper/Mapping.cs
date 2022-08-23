using AutoMapper;
using proje_data.Model;
using proje_dto.dto;

namespace proje_service.Mapper
{
    public class Mapping:Profile
    {
        public void MappingProfile()
        {
            CreateMap<Country, CountryDto>().ReverseMap();
            CreateMap<Department, DepartmentDto>().ReverseMap();
            CreateMap<Employee, EmployeeDto>().ReverseMap();
            CreateMap<Folder, FolderDto>().ReverseMap();
        }
    }
}
