using AutoMapper;
using BusinessLayer.DTOs.Response;
using DataAccess.Models;
namespace BusinessLayer.Services
{
    public interface IPeopleService
    {
        List<PersonResponseModel> Get();
    }

    class PeopleService : IPeopleService
    {
        private readonly AdventureWorks2019Context _dbContext;
        private readonly IMapper _mapper;

        public PeopleService(AdventureWorks2019Context context,IMapper mapper)
        {
            _dbContext = context;
            _mapper = mapper;
        }

        public List<PersonResponseModel> Get()
        {
            var people = _dbContext.People.Take(10).ToList();
            return _mapper.Map<List<PersonResponseModel>>(people);
        }
    }
}
