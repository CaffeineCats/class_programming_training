public class Customer
{
    private string _customerName;
    private Address _address;

    // Since there is no user interaction, I will assume that address is correct and accurate when Order is created.
    // I could create another constructor or methods to add/delete address, and an address list, but not required.
    public Customer(string name, Address address)
    {
        _customerName = name;
        _address = address;
    }

    public string GetCustomerName()
    {
        return _customerName;
    }

    public string GetCustomerAddress()
    {
        return _address.GetAddress();
    }

    public bool IsCustomerAddressInsideAmerica()
    {
        return _address.IsAmericanAddress();
    }
}