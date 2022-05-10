using System.ComponentModel.DataAnnotations;

namespace Tickets.Core.Entities
{
    public class Segments
    {
        public int Id { get; set; }
        public bool Is_passed { get; set; }
        public string Operation_type { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime Operation_time { get; set; }
        public string Operation_place { get; set; }

        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Patronymic { get; set; }
        public int? Doc_type { get; set; }
        public int? Doc_number { get; set; }
        [DataType(DataType.Date)]
        public DateTime? Birthdate { get; set; }
        public string? Gender { get; set; }
        public string? Passenger_type { get; set; }
        public int Ticket_number { get; set; }
        public int? Ticket_type { get; set; }

        public string? Airline_code { get; set; }
        public int? Flight_num { get; set; }
        public string? Depart_place { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime? Depart_datetime { get; set; }
        public string? Arrive_Place { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime? Arrive_datetime { get; set; }
        public string? Pnr_id { get; set; }
    }
}
