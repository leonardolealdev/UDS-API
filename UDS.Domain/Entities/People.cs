using Newtonsoft.Json;

namespace UDS.Domain.Entities
{
    public class People
    {
        public string Name { get; set; }
        public string Height { get; set; }
        public string Mass { get; set; }
        [JsonProperty("hair_color")]
        public string HairColor { get; set; }
        [JsonProperty("skin_color")]
        public string SkinColor { get; set; }
        [JsonProperty("eye_color")]
        public string EyeColor { get; set; }
        [JsonProperty("birth_year")]
        public string BirthYear { get; set; }
        public string Gender { get; set; }
        public string Homeworld { get; set; }
        public List<string> Films { get; set; } = new List<string>();
        public List<string> Species { get; set; } = new List<string>();
        public List<string> Vehicles { get; set; } = new List<string>();
        public List<string> Starships { get; set; } = new List<string>();
        public DateTime Created { get; set; }
        public DateTime Edited { get; set; }
        public string URL { get; set; }
    }
}
