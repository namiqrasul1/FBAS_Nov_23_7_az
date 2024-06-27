using System.Text.Json.Serialization;

namespace Lesson14AdapterStreamSerialization.Models
{
    internal class Car
    {
        public string Vendor { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        [JsonIgnore]
        public int Month { get; set; }
        public override string ToString()
        {
            return $"Vendor: {Vendor}. Model: {Model}. Year: {Year}";
        }
    }
}
