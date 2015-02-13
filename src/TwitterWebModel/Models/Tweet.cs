using System;

namespace Twitter.WebModel.Models
{
    public class Tweet
    {
        public int Id { get; set; }
        public ApplicationUser Author { get; set; }
        public string Text { get; set; }
        public DateTime CreatedAt { get; set; }
    }


}