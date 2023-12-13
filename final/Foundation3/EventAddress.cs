public class EventAddress
{
    private string _street;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    public EventAddress(string street, string city, string stateOrProvince , string country)
    {
        _street = street;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }

    public string GetAddress()
    {
        return $"Address: {_street}, {_city}, {_stateOrProvince}, {_country}.";
    }
}