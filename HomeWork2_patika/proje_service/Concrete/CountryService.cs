using AutoMapper;
using proje_data.Model;
using proje_data.Repository;
using proje_data.UnitOfWork;
using proje_dto.dto;
using proje_service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_service.Concrete
{
    public class CountryService : BaseService<CountryDto, Country>, ICountryService
    {
        public CountryService(ICountryRepository countryRepository, IMapper mapper, IUnitOfWork unitOfWork) : base(countryRepository, mapper, unitOfWork)
        {
        }
    }
}
