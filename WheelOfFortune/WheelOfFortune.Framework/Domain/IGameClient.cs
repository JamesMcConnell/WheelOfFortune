using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WheelOfFortune.Framework.Domain
{
    public interface IGameClient
    {
        string GetGameState { get; set; }
    }
}
