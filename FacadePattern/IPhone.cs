namespace Design_Patterns.FacadePattern
{
    public class IPhone : IIPhone
    {
        public string Name { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public int Price { get; set; }

        public string GetIPhone(string _name, int _quantity, int _price)
        {
            Name = _name;
            Quantity = _quantity;
            Price = _price;

            return $"Name: {Name}, Quantity: {Quantity}, Price: {Price}";
        }
    }
}