namespace Challenge_20
{
    class Transaction
    {
        public double tax { get; set; }
        public double order { get; set; }
        public double ToTal()
        {
            return order + tax;
        }
    }
}
