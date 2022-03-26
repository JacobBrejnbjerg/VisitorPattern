namespace VisitorPattern
{
    public class Employee : IElement
    {
        public double Salary { get; set; }
        public int Seniority { get; set; }
        public int VacationDays { get; set; }
                
        public override string ToString()
        {
            return "Salary: " + Salary + "\r\n" +
                   "Seniority: " + Seniority + "\r\n" +
                   "VacationDays: " + VacationDays + "\r\n";
        }

        // Implementerer Accept fra IElement
        public void Accept(IVisitor visitor)
        {
            visitor.VisitEmployee(this);
        }

    }
}
