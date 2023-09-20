using UnityEngine.SceneManagement;
namespace GB.Loop
{
    public class LoseState : BaseState
    {
        public override void Initialize()
        {
            gameController.UIController.LoseView.ShowView();
            gameController.UIController.LoseView.AddCallbackToButton(RestartGame);
        }

        public override void Dispose()
        {
            gameController.UIController.LoseView.HideView();
        }
        public void RestartGame()
        {
            SceneManager.LoadScene(0);
        }
    }
}

