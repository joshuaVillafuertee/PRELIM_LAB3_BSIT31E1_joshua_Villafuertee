using System;

namespace PRELIM_LAB3_BSIT31E1_joshua_Villafuerte.Models
{
    public abstract class BaseEntity : IDescribeable
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDay { get; set; }

        public int GetAge()
        {
            var today = DateTime.Today;
            var age = today.Year - BirthDay.Year;
            if (BirthDay > today.AddYears(-age)) age--;
            return age;
        }

        public string GetFullName()
        {
            return $"{FirstName} {MiddleName}. {LastName}";
        }

        public virtual string GetDescription()
        {
            return $"{GetFullName()} {GetAge()}";
        }
    }
}
