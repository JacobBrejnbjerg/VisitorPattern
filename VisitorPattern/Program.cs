using VisitorPattern;

// Create employee object
Employee goodEmployee = new Employee()
{
    Salary = 20000,
    Seniority = 5,
    VacationDays = 5 // This employee has 5 vacation days left because he has not spent it all
};

Employee badEmployee = new Employee()
{
    Salary = 20000,
    Seniority = 1,
    VacationDays = 0 // This employee has no vacation days left because he has spent them all
};

Console.WriteLine("Good employee");
Console.WriteLine(goodEmployee.ToString());

Console.WriteLine("Bad employee");
Console.WriteLine(badEmployee.ToString());


Console.WriteLine("Applying visitors to both employees");

// Apply all visitors to goodEmployee
goodEmployee.Accept(new SalaryVisitor()); // Add 8% to salary
goodEmployee.Accept(new SeniorityVisitor()); // Add seniority
goodEmployee.Accept(new VacationVisitor()); // Refresh vacation days

Console.WriteLine("Good employee");
Console.WriteLine(goodEmployee.ToString());

// Applying visitors to badEmployee
badEmployee.Accept(new SeniorityVisitor()); // Does not get higher salary
badEmployee.Accept(new VacationVisitor());

Console.WriteLine("Bad employee");
Console.WriteLine(badEmployee.ToString());