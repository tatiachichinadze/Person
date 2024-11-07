
public class Person

{

    public string Name { get; set; }

    public int Age { get; set; }




    public Person(string name, int age)

    {
        Name = name;
        Age = age;
    }

    public Person ChangeNameAndAge(string newName, int newAge)
    {
        Name = newName;
        Age = newAge;
        return this;

    }
    public void PrintPersonInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }

    static void Main(string[] args)
    {
        string personName = "Tamta";
        int personAge = 20;
        Person person1 = new Person(personName, personAge);
        Person person2 = person1;
        person2.ChangeNameAndAge("Tatia", 32);
        person1.PrintPersonInfo();
        person2.PrintPersonInfo();
    }
}
