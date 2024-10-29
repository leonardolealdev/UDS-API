using UDS.Domain.Entities;

namespace UDS.Domain.Dto.Output
{
    public class PeoplesOutputDto
    {
        public int Count { get; set; }
        public List<People> Results { get; set; } = new List<People>();
    }
}
