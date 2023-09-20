namespace GB.Loop
{
    public class StartState : BaseState
    {
        public override void Initialize()
        {
            gameController.UIController.StartView.ShowView();
            gameController.InputSystem.changeDirection += StartGame;
        }
        public override void Tick()
        {
            gameController.InputSystem.UpdateInputs();
        }
        public override void Dispose()
        {
            gameController.UIController.StartView.HideView();
            gameController.InputSystem.changeDirection = null;
        }
        private void StartGame()
        {
            gameController.ChangeState(new GameState());
        }
    }

}
