namespace VisitorPattern
{
    public class SeniorityVisitor : IVisitor
    {
        public void VisitEmployee(Employee employee)
        {
            employee.Seniority += 1;
        }
    }
}