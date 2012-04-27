using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WheelOfFortune.Framework.Domain.Implementation
{
    internal sealed class GameClient : IGameClient
    {
        #region IGameClient Members
        public string GetGameState { get; set; }
        #endregion
    }
}
