using System.Collections.Generic;
using Twitter.Data.Model;

namespace Twitter.Models
{
    public class Profile
    {
        public string UserName { get; set; }
        public IEnumerable<Tweet> Tweets { get; set; }
    }
}