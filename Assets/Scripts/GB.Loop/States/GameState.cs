namespace GB.Loop
{
    public class GameState : BaseState
    {
        public override void Initialize()
        {
            gameController.UIController.GameView.ShowView();
            gameController.InputSystem.changeDirection += gameController.PlayerMovement.ChangeWindDirection;
            gameController.TimeSystem.StartCounting();
            gameController.PlayerMovement.AddOnLoseListener(LoseGame);
        }
        public override void Tick()
        {
            gameController.InputSystem.UpdateInputs();
            gameController.PlayerMovement.UpdatePlayerPosition();
            gameController.CameraController.UpdateCameraPosition();
            gameController.HeightSystem.UpdateHeight(gameController.PlayerMovement.PlayerPos);
            gameController.TimeSystem.UpdateTime();
            gameController.UIController.GameView.UpdateHeight(gameController.HeightSystem.Height);
            gameController.UIController.GameView.UpdateTime(gameController.TimeSystem.SecondsPassed);
        }
        public override void FixedTick()
        {
            gameController.LevelSpawner.UpdateLevel();
        }
        public override void Dispose()
        {
            gameController.InputSystem.changeDirection = null;
            gameController.PlayerMovement.AddOnLoseListener(null);
            gameController.UIController.GameView.HideView();
        }
        public void LoseGame()
        {
            gameController.ChangeState(new LoseState());
        }

    }
}


