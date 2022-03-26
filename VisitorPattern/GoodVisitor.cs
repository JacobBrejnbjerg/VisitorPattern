namespace VisitorPattern
{
    public class GoodVisitor : IVisitor
    {
        public void VisitEmployee(Employee employee)
        {
            Console.WriteLine("Good Visitor: " + employee.GetType().Name);
            employee.Seniority += 1;
            employee.VacationDays += 20;
            employee.Salary *= 1.30;
        }
    }
}
