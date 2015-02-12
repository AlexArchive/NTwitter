using System.Collections.Generic;
using Microsoft.AspNet.Identity;

namespace Twitter.Models
{
    public class ApplicationUser : IdentityUser
    {
        public virtual ICollection<Tweet> Tweets { get; set; }
    }
}