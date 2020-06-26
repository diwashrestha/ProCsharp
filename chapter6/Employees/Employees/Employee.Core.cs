namespace Employees
{
    partial class Employee
    {
        // Field data.
        private string empName;
        private int empID;
        private float currPay;
        private int empAge;
        private string empSSN = "";




        // Constructors.
        public Employee() { }

        public Employee(string name, int id, float pay)
            : this(name, (int) 0, id, pay) { }

        public Employee(string name, int age, int id, float pay)
        {
            Name = name;
            ID = id;
            Age = age;
            Pay = pay;
        }

        public Employee(string name, int age, int id, float pay, string ssn)
            : this(name, age, id, pay)
        {
            empSSN = ssn;
        }

    }
}
