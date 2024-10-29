using UDS.Domain.Dto.Output;

namespace UDS.Domain.Interfaces.Services
{
    public interface IPeopleService
    {
        Task<PeoplesOutputDto> List();
    }
}
