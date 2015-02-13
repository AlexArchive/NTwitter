using System.ComponentModel.DataAnnotations;

namespace Twitter.WebModel.Models
{
    public class TweetInput
    {
        [Required]
        [MaxLength(140)]
        public string TweetText { get; set; }
    }
}