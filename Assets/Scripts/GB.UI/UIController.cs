using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace GB.UI
{
    public class UIController : MonoBehaviour
    {
        [SerializeField]
        private MenuView menuView;
        [SerializeField]
        private GameView gameView;
        [SerializeField]
        private LoseView loseView;
        [SerializeField]
        private StartView startView;

        public MenuView MenuView => menuView;
        public GameView GameView => gameView;
        public LoseView LoseView => loseView;
        public StartView StartView => startView;
    }
}

