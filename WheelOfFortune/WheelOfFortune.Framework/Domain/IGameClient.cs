using System.Collections.Generic;

namespace WheelOfFortune.Framework.Domain
{
    public interface IGameClient
    {
        GameState GetGameState();
        void StartGame();
        IList<Player> AddPlayer(string name);
        IList<Player> GetCurrentPlayers();
    }
}
