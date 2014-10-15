namespace Events
{
    using System;
    using System.Text;

    public class Event : IComparable
    {
        private DateTime date;
        private String title;
        private String location;
        
        public Event(DateTime date, String title, String location)
        {
            this.Date = date;
            this.Title = title;
            this.Location = location;
        }

        public DateTime Date
        {
            get
            {
                return this.date;
            }
            set
            {
                this.date = value;
            }
        }

        public string Title
        {
            get
            {
                return this.title;
            }
            set
            {
                this.title = value;
            }
        }

        public string Location
        {
            get
            {
                return this.location;
            }
            set
            {
                this.location = value;
            }
        }

        public int CompareTo(object otherObject)
        {
            Event otherEvent = otherObject as Event;
            int byDate = this.Date.CompareTo(otherEvent.date);
            int byTitle = this.Title.CompareTo(otherEvent.title);
            int byLocation = this.Location.CompareTo(otherEvent.location);

            if (byDate == 0)
            {
                if (byTitle == 0)
                {
                    return byLocation;
                }
                else
                {
                    return byTitle;
                }
            }
            else
            {
                return byDate;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder(date.ToString("yyyy-MM-ddTHH:mm:ss"));

            result.Append(" | " + this.Title);

            if (location != null && location != "")
            {
                result.Append(" | " + location);
            }
            
            return result.ToString();
        }
    }
}