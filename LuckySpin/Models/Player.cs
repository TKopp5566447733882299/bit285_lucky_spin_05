using System.ComponentModel.DataAnnotations;
namespace LuckySpin.Models
{
    public class Player
    {
        [Required (ErrorMessage = "Make sure to add a name")]
        public string FirstName { get; set; }


        [Range (1, 9, ErrorMessage = "Please enter a number")]
        public int Luck { get; set; }
    }
}