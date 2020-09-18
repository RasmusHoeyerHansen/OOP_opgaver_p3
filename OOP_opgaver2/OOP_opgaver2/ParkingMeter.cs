namespace OOP_opgaver2
{
    public abstract class ParkingMeter
    {
        protected int _minutesPerCoin;
        
        private int Coin { get; set; }
        public void InsertCoin(int coin)
        {
            Coin += coin;
        }

        public int calcMinutes() {
            return Coin * _minutesPerCoin;
        }
    }
}

