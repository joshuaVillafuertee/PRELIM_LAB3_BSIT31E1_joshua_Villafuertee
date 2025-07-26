namespace PRELIM_LAB3_BSIT31E1_joshua_Villafuerte.Models
{
    public class Customer : BaseEntity
    {
        public int CustomerId { get; set; }

        public override string GetDescription()
        {
            return $"Regular Customer, {GetFullName()} {GetAge()} {CustomerId}";
        }
    }
}
