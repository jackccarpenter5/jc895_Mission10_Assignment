using APIFun.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIFun.DTOs
{
    public class BowlerWithTeamDTO
    {
        public int Id { get; set; }

        public string? Address { get; set; }

        public string? City { get; set; }

        public string? State { get; set; }

        public string? Zip { get; set; }

        public string? PhoneNumber { get; set; }

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? MiddleInitial { get; set; }
        public string TeamName { get; set; }
    }
}

