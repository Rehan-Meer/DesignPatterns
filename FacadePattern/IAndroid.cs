namespace Design_Patterns.FacadePattern
{
    public interface IAndroid
    {
        string Name { get; set; }
        int Quantity { get; set; }
        int Price { get; set; }
        string GetAndroid(string _name, int _quantity, int _price);
    }
}
