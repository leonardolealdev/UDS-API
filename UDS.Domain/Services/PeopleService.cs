using UDS.Domain.Dto.Output;
using UDS.Domain.Interfaces.Repositories;
using UDS.Domain.Interfaces.Services;

namespace UDS.Domain.Services
{
    public class PeopleService: IPeopleService
    {
        private readonly IPeopleRepository _repository;
        public PeopleService(IPeopleRepository repository)
        {
            _repository = repository;
        }

        public async Task<PeoplesOutputDto> List()
        {
            return await _repository.List();
        }
    }
}
