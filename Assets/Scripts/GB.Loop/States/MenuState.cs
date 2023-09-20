namespace GB.Loop 
{
    public class MenuState : BaseState
    {
        public override void Initialize()
        {
            gameController.UIController.MenuView.ShowView();
            gameController.UIController.MenuView.AddCallbackToPlayBtn(Play);
        }
        public override void Tick()
        {
            gameController.InputSystem.UpdateInputs();
        }
        public override void Dispose()
        {
            gameController.UIController.MenuView.HideView();
        }
        private void Play()
        {
            gameController.ChangeState(new StartState());
        }
    }
}


