public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order( List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public double TotalPrice()
    {
        double totalPrice = 0;
        foreach (Product product in _products )
        {
            totalPrice +=  product.Caculate();
        }
        
        
        if ( _customer.IsInUSA())
        {
            totalPrice += 5;
        }
        else 
        {
            totalPrice += 35;
        }
        return totalPrice;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:\n";
        foreach ( Product product in _products)
        {
            packingLabel += $"Porduct Name: {product.GetProductName()}, Product ID: {product.GetProductId()}\n";
        }

        return packingLabel;
    }

    public string GetShippingLabel()
    {
       
        return $"Shipping Label:\nName: {_customer.GetName()}\nAddress:\n{_customer.GetAddress().GetFullAddress()}\n";
       
    }
}