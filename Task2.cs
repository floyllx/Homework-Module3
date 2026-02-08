public abstract class Employee
{
    public string Name { get; set; }
    public double BaseSalary { get; set; }
    public abstract double CalculateSalary();
}

public class PermanentEmployee : Employee
{
    public override double CalculateSalary()
    {
        return BaseSalary * 1.2; 
    }
}

public class ContractEmployee : Employee
{
    public override double CalculateSalary()
    {
        return BaseSalary * 1.1; 
    }
}

public class InternEmployee : Employee
{
    public override double CalculateSalary()
    {
        return BaseSalary * 0.8; 
    }
}

public class EmployeeSalaryCalculator
{
    public double CalculateSalary(Employee employee)
    {
        return employee.CalculateSalary();
    }
}

public class FreelancerEmployee : Employee
{ 
    public override double CalculateSalary()
    {
        return BaseSalary * 1.05; 
    }
}