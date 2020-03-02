namespace T1904A
{
    public class MobilePhone : Phone
    {
        public MobilePhone()
        {
        }

        public MobilePhone(string phonename, string phonetype, float phoneprice) : base(phonename, phonetype, phoneprice)
        {
        }

        static void Main(string[] args)
        {
            Phone p =new Phone();
            p.display();
        }
    }
}