using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Managers
{
    public class GameMenager : MonoBehaviour
    {   

        private void Awake()
        {
            Application.targetFrameRate = 60;
            OnGameOpen();
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

        }

        private void OnGameClose()
        {

        }

        private void OnApplicationPause(bool pause)
        {
            
        }

    } 
}
