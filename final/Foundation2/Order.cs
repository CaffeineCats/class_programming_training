public class Order
{
    private Customer _customer;
    private List<Product> _products;

    // Since this is not an interface for shopping but labeling instead, I will assume all the data is accurate up to this point.
    // If user wants to add/delete products or addresses, it will be done before this class is loaded with data.

    public Order(Customer customer, List<Product> products)
    {
        _customer =customer;
        _products = products;
    }
    public string GetOrderTotalCost()
    {
        double totalCost = 0;

        foreach (Product product in _products)
        {
            totalCost += product.GetProductTotalCost();
        }

        totalCost = _customer.IsCustomerAddressInsideAmerica() ? totalCost += 5 : totalCost += 35;

        return $"Total: {totalCost.ToString("0.00")}";
    }

    public string GetPackingLabel()
    {
        string packingLabel = "Products:\n";

        foreach (Product product in _products)
        {
            packingLabel += $"\n{product.GetProductLabel()}";
        }

        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return $"Customer Name: {_customer.GetCustomerName()}\n\n{_customer.GetCustomerAddress()}";
    }

}   