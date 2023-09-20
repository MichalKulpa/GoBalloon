using System.Collections;
using System;
using UnityEngine;
namespace GB.Loop
{
    public class InputSystem
    {
        public Action changeDirection;

        public void UpdateInputs()
        {
            if (Input.GetKeyDown(KeyCode.Mouse0)||Input.GetKeyDown(KeyCode.Space))
            {
                changeDirection?.Invoke();
            }
        }
    }
}

