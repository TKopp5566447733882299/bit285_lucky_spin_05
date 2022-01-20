using System;
using System.Linq;
namespace LuckySpin.Models
{
    //A more robust and cleaner Spin Model
    public class Spin
    {
        Random random = new Random();
        private int[] number; //a spin array
        public bool isWinning;

        //Properties
        public Player Player { get; set; } //read-write

        public bool IsWinning { get { return isWinning; } } //read only

        public int[] Number
        {
            get
            {
                number = new int[] { random.Next(10), random.Next(10), random.Next(10) };
                isWinning = number.Contains(Player.Luck); //Use the System.Linq method to search the array
                return number;
            }
        }
        //Create a public getter that makes the decision to display the image or not by returning "block" or "none" for the Razor templates CSS
        public string Display
        {
            get
            {
                if (isWinning)
                {
                    return "display:block";
                }
                else
                {
                    return "display:none";
                }
            }
        }
    }

}
