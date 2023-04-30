namespace Design_Patterns.FacadePattern
{
    public class MobileShop
    {
        private IIPhone _iphoneSection;
        private IAndriod iAndroidSection;

        public MobileShop()
        {
            _iphoneSection = new IPhone();
            iAndroidSection = new Android();
        }

        public void IPhoneSection() => Console.WriteLine(_iphoneSection.GetIphones());

        public void AndroidSection() => Console.WriteLine(iAndroidSection.GetAndroids());

        static void Main()
        {
            var shopKeeper = new MobileShop();
            shopKeeper.AndroidSection();
            shopKeeper.IPhoneSection();
        }
    }
}
