namespace Design_Patterns.FacadePattern
{
    public class MobileShop
    {
        private readonly IIPhone _iphone;
        private readonly IAndroid iAndroid;

        public MobileShop()
        {
            _iphone = new IPhone();
            iAndroid = new Android();
        }

        public string GetIPhone(string model, int quantity, int price) => _iphone.GetIPhone(model, quantity, price);

        public string GetAndroid(string model, int quantity, int price) => iAndroid.GetAndroid(model, quantity, price);

        static void Main()
        {
            var shopKeeper = new MobileShop();
            var iphoneDetail = shopKeeper.GetIPhone("iPhone X", 1, 999);
            var androidDetail = shopKeeper.GetAndroid("Samsung Galaxy S20", 1, 799);
            Console.WriteLine(iphoneDetail);
            Console.WriteLine(androidDetail);
        }
    }
}