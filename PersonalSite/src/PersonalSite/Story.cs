using PersonalSite.Services;
using System;
using System.Collections.Generic;

namespace PersonalSite.ViewModels
{
    public static class HandyFunctions {
        public static string TruncateAtWord(this string value, int length)
        {
            if (value == null || value.Length < length || value.IndexOf(" ", length) == -1)
                return value;

            return value.Substring(0, value.IndexOf(" ", length));
        }
        public static string ToRelativeDate(this DateTime value)
        {
            const int SECOND = 1;
            const int MINUTE = 60 * SECOND;
            const int HOUR = 60 * MINUTE;
            const int DAY = 24 * HOUR;
            const int MONTH = 30 * DAY;

            var ts = new TimeSpan(DateTime.UtcNow.Ticks - value.Ticks);
            double delta = Math.Abs(ts.TotalSeconds);

            if (delta < 1 * MINUTE)
                return ts.Seconds == 1 ? "one second ago" : ts.Seconds + " seconds ago";

            if (delta < 2 * MINUTE)
                return "a minute ago";

            if (delta < 45 * MINUTE)
                return ts.Minutes + " minutes ago";

            if (delta < 90 * MINUTE)
                return "an hour ago";

            if (delta < 24 * HOUR)
                return ts.Hours + " hours ago";

            if (delta < 48 * HOUR)
                return "yesterday";

            if (delta < 30 * DAY)
                return ts.Days + " days ago";

            if (delta < 12 * MONTH)
            {
                int months = Convert.ToInt32(Math.Floor((double)ts.Days / 30));
                return months <= 1 ? "one month ago" : months + " months ago";
            }
            else
            {
                int years = Convert.ToInt32(Math.Floor((double)ts.Days / 365));
                return years <= 1 ? "one year ago" : years + " years ago";
            }
        }
    }
    public class Story
    {

        public string Link { get; set; }
        public string LinkComments { get; set; }
        public string ImageUrl { get; set; }
        public string ImageAlt { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Summary { get; set; }

        public string SummaryShort
        {
            get { return this.Summary.TruncateAtWord(140); }
        }        

        public DateTime Published { get; set; }
        public string RelativeDate
        {
            get { return this.Published.ToRelativeDate(); }
        }
        public List<Category> Category { get; set; }
        public List<Type> Type { get; set; }
        public int CommentCount { get; set; }                
        public string Class
        {
            get { return "category-mobile"; }
        }

        private string body;

        public string Body
        {
            get {
                return body ?? Content.ConvertMarkdown(this.BodyMarkDown);
              }
            set { body = value; }
        }

        public string BodyMarkDown { get; internal set; }
    }
}