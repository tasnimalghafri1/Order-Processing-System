public class Customer
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }

    public Customer()
    {
        Id = string.Empty;
        Name = string.Empty;
        Email = string.Empty;
    }

    public Customer(string id, string name, string email)
    {
        Id = id;
        Name = name;
        Email = email;
    }

    public override string ToString()
    {
        return Name; // عشان يظهر الاسم في ComboBox
    }
}