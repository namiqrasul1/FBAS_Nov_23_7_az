using System.Xml.Serialization;

namespace Lesson14AdapterStreamSerialization.Models
{
    [Serializable]
    public class Student
    {
        [XmlAttribute(AttributeName = "Identifier")]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        [XmlElement]
        public string Name { get; set; }
        [XmlElement]
        public string Surname { get; set; }
        [XmlElement]
        public string BirthDate { get; set; }
        [XmlArray]
        public List<byte> Scores { get; set; }
        public double Average { get => Scores.Average(i => i); }

    }
}
