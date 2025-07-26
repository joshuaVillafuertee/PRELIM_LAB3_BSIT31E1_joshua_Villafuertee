namespace PRELIM_LAB3_BSIT31E1_joshua_Villafuerte.Models
{
    public class VipCustomer : Customer
    {
        public bool IsVip { get; set; } = true;

        public override string GetDescription()
        {
            return $"VIP Customer, {GetFullName()} {GetAge()} {CustomerId}";
        }
    }
}
