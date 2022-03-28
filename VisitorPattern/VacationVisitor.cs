namespace VisitorPattern
{
    public class VacationVisitor : IVisitor
    {
        public void VisitEmployee(Employee employee)
        {
            // Set vacation days to 20
            employee.VacationDays = 20;
        }
    }
}
