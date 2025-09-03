namespace CarServiceManager
{
    public class ServiceOrder
    {
        public Car Car { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
        public double Cost { get; set; }

    }
}
