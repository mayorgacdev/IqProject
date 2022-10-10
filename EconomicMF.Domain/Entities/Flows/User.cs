
using System;

#nullable disable

namespace EconomicMF.Domain.Entities.Flows
{
    public partial class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Dni { get; set; }
        public string Password { get; set; }
        public bool State { get; set; }
        public DateTime Creation { get; set; }
    }
}
