using System.ComponentModel.DataAnnotations;

namespace Tickets.Core.Entities
{
    public class Segments
    {
        public int Id { get; set; }
        public string Operation_type { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime Operation_time { get; set; }
        public string Operation_place { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public int Doc_type { get; set; }
        public int Doc_number { get; set; }
        [DataType(DataType.Time)]
        public DateTime Birthdate { get; set; }


    }
}
