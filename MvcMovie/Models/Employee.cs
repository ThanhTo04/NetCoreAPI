public class Employee : Person
{
    public string EmployeeId { get; set; }
    public int Age { get; set; }

    public Employee() { }

    public Employee(
        string personId,
        string fullName,
        string address,
        string employeeId,
        int age
    ) : base(personId, fullName, address)
    {
        EmployeeId = employeeId;
        Age = age;
    }
}
