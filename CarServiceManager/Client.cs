namespace CarServiceManager
{
   public class Client
    {
        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public List<Car> Cars { get; set; } = new List<Car>();
    }
}
