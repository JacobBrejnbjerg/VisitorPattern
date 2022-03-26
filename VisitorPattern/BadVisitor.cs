namespace VisitorPattern
{
    public class BadVisitor : IVisitor
    {
        public void VisitEmployee(Employee employee)
        {
            Console.WriteLine("Bad Visitor: " + employee.GetType().Name);
            employee.Seniority += 1;
            employee.VacationDays += 5;
            employee.Salary *= 1.10;
        }
    }
}