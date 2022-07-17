using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Extentions;
using Signals;
using System;
using Controlers;
using Enums;

namespace Managers
{
    public class SaveMenager : MonoBehaviour
    {
        #region Self Veriables

        #region Prive Veriables

        private bool _status;
        

        #endregion

        #region Serilazible Veriables

        [SerializeField] SaveDataController saveController;
        [SerializeField] LoadDataController loadController; 
        
        #endregion

        #endregion

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
            Load();
        }

        private void OnGameClose()
        {
            Save();

        }

        private void OnGamePause(bool value)
        {
            _status = value;
            Save();
        }
        private void Load()
        {

        }
        private void Save()
        {
            
        }








    }

}