using System.ComponentModel.DataAnnotations;

namespace Twitter.Models
{
    public class TweetInput
    {
        [Required]
        [MaxLength(140)]
        public string TweetText { get; set; }
    }
}