namespace ExPolimorfismo.Entities
{
    class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; protected set; }

        public OutsourcedEmployee()
        {

        }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge) : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + (1.1 * AdditionalCharge);
        }
    }
}