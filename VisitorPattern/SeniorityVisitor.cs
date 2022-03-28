namespace VisitorPattern
{
    public class SeniorityVisitor : IVisitor
    {
        public void VisitEmployee(Employee employee)
        {
            // Set the employee's seniority
            employee.Seniority += 1;
        }
    }
}