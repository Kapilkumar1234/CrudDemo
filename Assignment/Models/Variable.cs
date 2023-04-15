using System;
using System.Collections.Generic;

namespace Assignment.Models
{
    public partial class Variable
    {
        public int Id { get; set; }
        public string VariableName { get; set; } = null!;
        public DateTime? StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string CityName { get; set; } = null!;
    }
}
