using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WheelOfFortune.Framework.Domain.Implementation
{
    internal sealed class GameClient : IGameClient
    {
        private IList<Player> _currentPlayers = new List<Player>();
        private GameState _gameState = GameState.Ready;

        #region IGameClient Members
        public GameState GetGameState()
        {
            return _gameState;
        }

        public void StartGame()
        {
            _gameState = GameState.InProgress;
        }

        public IList<Player> GetCurrentPlayers()
        {
            return new List<Player>
            {
                new Player { Id = -1, Name = "Player 1", LettersGuessed = new List<string>(), Winnings = 0 },
                new Player { Id = -1, Name = "Player 2", LettersGuessed = new List<string>(), Winnings = 0 },
                new Player { Id = -1, Name = "Player 3", LettersGuessed = new List<string>(), Winnings = 0 }
            };
        }

        public IList<Player> AddPlayer(string name)
        {
            return null;

            //if (_currentPlayers.Count == 3)
            //{
            //    return null;
            //}

            //if (_currentPlayers.Count == 0)
            //{
            //    _gameState = GameState.WaitingForPlayers;
            //}

            //_currentPlayers.Add(new Player
            //{
            //    Id = -1,
            //    Name = name,
            //    LettersGuessed = new List<string>(),
            //    Winnings = 0.0
            //});

            //return _currentPlayers;
        }
        #endregion
    }
}
