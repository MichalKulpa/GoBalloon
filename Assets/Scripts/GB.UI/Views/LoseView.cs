using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
namespace GB.UI
{
    public class LoseView : BaseView
    {
        [SerializeField]
        private Button restartButton;

        public void AddCallbackToButton(UnityAction callback)
        {
            restartButton.onClick.AddListener(callback);
        }
    }
}

