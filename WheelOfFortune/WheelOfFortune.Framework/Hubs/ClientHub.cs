using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WheelOfFortune.Framework.Domain;
using WheelOfFortune.Framework.Infrastructure;
using Ninject;

namespace WheelOfFortune.Framework.Hubs
{
    public class ClientHub
    {
        private IGameClient _gameClient;

        public ClientHub()
        {
            _gameClient = Container.Kernel.Get<IGameClient>();
        }
    }
}
