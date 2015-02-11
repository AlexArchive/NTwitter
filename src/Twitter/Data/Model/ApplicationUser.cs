using System;
using System.Collections.Generic;
using Microsoft.AspNet.Identity;

namespace Twitter.Data.Model
{
    public class ApplicationUser : IdentityUser
    {
        public virtual ICollection<Tweet> Tweets { get; set; }
    }
}