using Sirenix.Serialization;
using UnityEngine;
using Utils.SingletonPattern;

namespace Game.GameState
{
    public class GameStateController : SingletonMonoBehaviour<GameStateController>
    {
        [OdinSerialize]
        public GameState currentGameState;

        private void Start()
        {
            currentGameState?.StartState();
        }

        private void Update()
        {
            currentGameState?.UpdateState();
        }

        public void ChangeGameState(GameState gameState)
        {
            gameState.StartState();
            currentGameState = gameState;
        }
    }
}