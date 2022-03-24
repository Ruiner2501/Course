using System.ComponentModel.DataAnnotations;

namespace Course.Models.ViewModels
{
    public class CreateReviewViewModel
    {
        [Required]
        
        public string Title { get; set; }
        public string Text { get; set; }
        public byte[] Image { get; set; }
    }
}
