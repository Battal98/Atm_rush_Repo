using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Extentions;
using Signals;
using System;
using Controllers;


namespace Managers
{
    public class SaveMenager : MonoBehaviour
    {
        #region Self Veriables

        #region Prive Veriables

        
       

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
            //CoreGameSignals.Instance.onWhencrash›tem += OnWhencrash›tem;
        }
        private void UnSubscribeEvents()
        {
            CoreGameSignals.Instance.onGameOpen -= OnGameOpen;
            CoreGameSignals.Instance.onGameClose -= OnGameClose;
            CoreGameSignals.Instance.onGamePause -= OnGamePause;
            //CoreGameSignals.Instance.onWhencrash›tem -= OnWhencrash›tem;
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
            
            saveController.SaveData();
        }

        private void OnGamePause(bool value)
        {
            
            if(value==false)Save();
            else Load();
        }
        private void Load()
        {
            loadController.LoadData();
        }
       
        private void Save()
        {  
            saveController.SaveData();
        }
        private void ChangeMoney()
        {   
            Load();
        }
        private void ChangeLevel()
        {
            Load();
        }
    }

}