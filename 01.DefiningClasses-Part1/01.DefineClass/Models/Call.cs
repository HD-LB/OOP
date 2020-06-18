namespace _01.DefineClass
{
    using System;

    public class Call
    {
        //Fields
        private DateTime dateTime;

        //Constuctor
        public Call()
        {
            this.dateTime = DateTime.Now;
        }

        //Proparties
        public string Time
        {
            get
            {
                return this.dateTime.ToString("HH:mm:ss");
            }
        }

        public string Date
        {
            get
            {
                return this.dateTime.ToString("dd/MM/yyyy");
            }
        }

        public string DailedPhoneNumber { get; set; }

        public uint Duration { get; set; }


        //Methods
        public override string ToString()
        {
            return string.Format("Dialed Phone Number: {0} - Duration: {1} - Date: {2}", this.DailedPhoneNumber, this.Duration, this.Date);
        }
    }
}
