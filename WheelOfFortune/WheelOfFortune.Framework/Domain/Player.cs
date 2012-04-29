using System.Collections.Generic;

namespace WheelOfFortune.Framework.Domain
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<string> LettersGuessed { get; set; }
        public double Winnings { get; set; }
    }
}
