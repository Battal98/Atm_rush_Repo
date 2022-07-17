using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Extentions;
using Signals;
using System;
using Controlers;
using Keys;

namespace Managers
{
    public class SaveMenager : MonoBehaviour
    {
        #region Self Veriables

        #region Prive Veriables

        private bool _status;
        private SaveGameDataParams saveGameDataParams;

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
            
            saveController.SaveEntry(saveGameDataParams);
        }

        private void OnGamePause(bool value)
        {
            _status = value;
            saveController.SaveEntry(saveGameDataParams);
        }
        private void Load()
        {

        }
       








    }

}