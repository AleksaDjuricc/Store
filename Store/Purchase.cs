using System;

namespace Store
{
    public class Purchase
    {
        private DateTime date;

        public Purchase(DateTime date)
        {
            this.date = date;
        }

        public Purchase() : base()
        {

        }

        public DateTime Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }
    }
}
