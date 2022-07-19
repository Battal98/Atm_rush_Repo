using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Signals;

namespace Managers
{
    public class GameMenager : MonoBehaviour
    {   

        private void Awake()
        {
            Application.targetFrameRate = 60;
            
        }

        private void OnEnable()
        {
            OnGameOpen();


        }

        private void OnDisable()
        {
            OnGameClose();
        }

        private void OnGameOpen()
        {
            CoreGameSignals.Instance.onGameOpen.Invoke();
        }

        private void OnGameClose()
        {
            CoreGameSignals.Instance.onGameClose.Invoke();
        }

        private void OnApplicationFocus(bool vaalue)
        {
            Debug.Log(vaalue);
        }

    } 
}
