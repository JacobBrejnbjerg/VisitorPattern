namespace VisitorPattern
{
    public class VacationVisitor : IVisitor
    {
        public void VisitEmployee(Employee employee)
        {
            employee.VacationDays = 20;
        }
    }
}
