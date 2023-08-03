namespace PolymorphismInhiretionExample
{
    public class Emploee : Person
    {
        public Emploee(int id) 
            : base(id)
        {
        }

        public string Position { get; set; }
        public double Salary { get; set; }

        public override string GetPersonalData()
        {
            return base.GetPersonalData() + '\n' + $@"Salary - {Salary}
Positions {Position}";
        }
    }
}
