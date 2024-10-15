using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.GameState
{
    public abstract class GameState
    {
        GameStateController controller;

        public GameState(GameStateController controller)
        {
            this.controller = controller;
        }

        public abstract void StartState();
        public abstract void UpdateState();
        public abstract void NextState();

    }
}
