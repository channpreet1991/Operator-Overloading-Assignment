using System;

public class Employee     {
    private int _id;
    private float salary;
    private string name;

    //------
    public Employee(int id, string name, float salary) {
        this._id = id;
        this.name = name;
        this.salary = salary;
    }

    //------
    public float getSalary() {
       return salary;
    }
    //------
    public string getName() {
       return name;
    }
    // overide '==' operator for comparing two Employee objects
    public static bool operator ==(Employee e1, Employee e2) {
        return e1._id == e2._id;
    }

    // !=
    public static bool operator !=(Employee e1, Employee e2) {
        return !(e1._id == e2._id);
    }

    public override bool Equals(object obj) {
        if (obj == null)
            return false;
        Employee e = obj as Employee;
        if ((object)e == null)
            return false;
        return (e._id == this._id);
    }


	// you can remove the main method
    public static void Main()
    {
        Employee e1 = new Employee(1, "John", 1000);
        Employee e2 = new Employee(1, "John", 1000);

        if (e1 == e2)
        {
            Console.WriteLine("e1 and e2 are equal");
        }
        else
        {
            Console.WriteLine("e1 and e2 are not equal");
        }
    }
}