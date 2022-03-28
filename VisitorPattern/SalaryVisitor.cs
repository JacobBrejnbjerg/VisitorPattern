namespace VisitorPattern
{
    public class SalaryVisitor : IVisitor
    {
        public void VisitEmployee(Employee employee)
        {
            // Set the salary of the employee
            employee.Salary *= 1.08;
        }
    }
}
