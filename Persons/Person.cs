using System;

public class Person
{
    private string name;
    private int age;
    private string email;

    public Person(string name, int age, string email = null)
    {
        this.name = name;
        this.age = age;
        this.email = email;
    }
    public Person(string name, int age) : this(name, age, null) { }
    public string Name
    {
        get { return this.name; }
        set
        {
            if (string.IsNullOrEmpty(this.name))
            {
                throw new ArgumentNullException("Empty name");
            }
            else
            {
                this.name = value;
            }
        }
    }
    public int Age
    {
        get { return this.age; }
        set
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentNullException("Age is out of range");
            }
            else
            {
                this.age = value;
            }
        }
    }
    public string Email
    {
        get { return this.email; }
        set
        {
            if (value != null && !value.Contains("@"))
            {
                throw new ArgumentException("Invalid email!");

            }
            else
            {
                this.email = value;
            }
        }
    }
    public override string ToString()
    {
        return string.Format("name: {0}, age: {1}", this.Name, this.Age) + (this.Email == null ? "" : ", email: " + this.Email);
    }

}

