namespace VisitorPattern
{
    public class SalaryVisitor : IVisitor
    {
        public void VisitEmployee(Employee employee)
        {
            employee.Salary *= 1.08;
        }
    }
}
