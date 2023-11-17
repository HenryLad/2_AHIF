namespace Queue.Logic;

class CustomerInQueue(string name, string phonenumber, CustomerInQueue? next)
{
    public string Name { get; set; } = name;
    public string PhoneNumber { get; set; } = phonenumber;
    public CustomerInQueue? Next { get; set; } = next;
}

