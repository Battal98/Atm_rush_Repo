using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Extentions;
using Signals;
using System;

namespace Managers
{
    public class SaveMenager : MonoBehaviour
    {


        private void OnEnable()
        {
            SubscribeEvents();
        }

        private void SubscribeEvents()
        {
            CoreGameSignals.Instance.onGameOpen += OnGameOpen;
            CoreGameSignals.Instance.onGameClose += OnGameClose;
            CoreGameSignals.Instance.onGamePause += OnGamePause;
        }
        private void UnSubscribeEvents()
        {
            CoreGameSignals.Instance.onGameOpen -= OnGameOpen;
            CoreGameSignals.Instance.onGameClose -= OnGameClose;
            CoreGameSignals.Instance.onGamePause -= OnGamePause;
        }

        private void OnDisable()
        {
            UnSubscribeEvents();
        }


        private void OnGameOpen()
        {
            LoadData();
        }

        private void OnGameClose()
        {
            SaveData();
        }

        private void OnGamePause(bool status)
        {
            SaveData();
        }
        private void LoadData()
        {

        }
        private void SaveData()
        {

        }








    }

}