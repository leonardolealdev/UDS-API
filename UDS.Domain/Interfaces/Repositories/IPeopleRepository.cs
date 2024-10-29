using UDS.Domain.Dto.Output;

namespace UDS.Domain.Interfaces.Repositories
{
    public interface IPeopleRepository
    {
        Task<PeoplesOutputDto> List();
    }
}
