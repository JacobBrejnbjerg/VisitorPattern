namespace VisitorPattern
{
    public class Employee
    {
        public double Salary { get; set; }
        public int Seniority { get; set; }
        public int VacationDays { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitEmployee(this);
        }

        public override string ToString()
        {
            return "Salary: " + Salary + "\r\n" +
                   "Seniority: " + Seniority + "\r\n" +
                   "VacationDays: " + VacationDays + "\r\n";
        }
    }
}
