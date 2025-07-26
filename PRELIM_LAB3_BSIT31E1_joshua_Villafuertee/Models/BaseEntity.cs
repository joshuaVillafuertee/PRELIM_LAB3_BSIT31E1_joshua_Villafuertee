using System;

namespace PRELIM_LAB3_BSIT31E1_joshua_Villafuerte.Models
{
    public abstract class BaseEntity : IDescribeable
    {
        public string FirstName { get; set; } = string.Empty;
        public string MiddleName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime BirthDay { get; set; }

        public string Email { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;

        public int GetAge()
        {
            var today = DateTime.Today;
            var age = today.Year - BirthDay.Year;
            if (BirthDay.Date > today.AddYears(-age)) age--;
            return age;
        }

        public string GetFullName()
        {
            return $"{FirstName} {MiddleName[0]}. {LastName}";
        }

        public virtual string GetDescription()
        {
            return $"{GetFullName()} {GetAge()}";
        }
    }
}
