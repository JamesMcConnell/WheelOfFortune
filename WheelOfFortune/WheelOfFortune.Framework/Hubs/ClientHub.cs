using System;
using Ninject;
using WheelOfFortune.Framework.Domain;
using WheelOfFortune.Framework.Infrastructure;
using SignalR.Hubs;

namespace WheelOfFortune.Framework.Hubs
{
    public class ClientHub : Hub
    {
        private IGameClient _gameClient;

        public ClientHub()
        {
            _gameClient = Container.Kernel.Get<IGameClient>();
        }

        public void StartConnection()
        {
            Caller.clientId = Guid.NewGuid();
        }

        public void GameStateRequest()
        {
            var gameState = _gameClient.GetGameState();
            Clients.gameStateResponse(gameState.ToString());
        }

        public void CurrentPlayersRequest()
        {
            var currentPlayers = _gameClient.GetCurrentPlayers();
            Clients.currentPlayersResponse(currentPlayers);
        }
    }
}
