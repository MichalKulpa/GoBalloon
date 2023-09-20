using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

namespace GB.UI
{
    public class MenuView : BaseView
    {
        [SerializeField]
        private Button playButton;
        [SerializeField]
        private Button optionButton;
        [SerializeField]
        private Button storeButton;
        [SerializeField]
        private Button muteButton;

        public void AddCallbackToPlayBtn(UnityAction callback)
        {
            playButton.onClick.AddListener(callback);
        }
        public void AddCallbackToOptionBtn(UnityAction callback)
        {
            optionButton.onClick.AddListener(callback);
        }
        public void AddCallbackToStoreBtn(UnityAction callback)
        {
            storeButton.onClick.AddListener(callback);
        }
        public void AddCallbackToMuteBtn(UnityAction callback)
        {
            muteButton.onClick.AddListener(callback);
        }

    }
}

