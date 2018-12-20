using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Personnel.Utilities
{
    public static class UserInfo
    {
        internal static string Strict;

        public static string Username { get; set; }
        public static string Fullname { get; set; }
        public static string Lastname { get; set; }
        public static string Givenname { get; set; }
        public static string EventName { get; set; }
        public static string Contact { get; set; }
        public static string Affiliation { get; set; }


        public static string EventDate { get; set; }
        public static string EventStrict { get; set; }
        public static string EventPartial { get; set; }
        public static string EventTime { get; set; }
        public static string UserId { get; set; }
        public static int EventId { get; set; }
        public static int EventCost { get; set; }
        public static string EventLocation { get; set; }
    }
}
