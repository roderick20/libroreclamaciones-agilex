using System;
using System.Collections.Generic;

#nullable disable

namespace BuzonDeSugerencias.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public Guid UniqueId { get; set; }
        public string TypeDoc { get; set; }
        public string NumberDoc { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string CellPhone { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public DateTime LastAccess { get; set; }
        public bool Enabled { get; set; }
        public bool RecibeEmail { get; set; }
        public bool IsAdmin { get; set; }
    }
}
