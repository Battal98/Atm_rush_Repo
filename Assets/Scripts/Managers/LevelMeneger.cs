using UnityEngine;
using Command;
using Signals;
using System;
using Data.ValueObject;

namespace Managers
{
    public class LevelMeneger : MonoBehaviour
    {
        #region Self Veriables

        #region Private Veraibles

        private int _leveID;
        private LoadGameDataParams loadGameDataParams;

        #endregion

        #region Public Variables

        //[Header("Data")] public LevelData Data;

        #endregion

        #region Serialized Variables

        [SerializeField] private GameObject levelHolder;

        [SerializeField] private LevelLoaderCommand levelLoader;
        [SerializeField] private ClearActiveLevelCommand levelClearer;

        #endregion


        #endregion

        private void Awake()
        {
            _leveID = GetLevelID();
            //Data = GetLevelData();
        }

        private object GetLevelData()
        {
            throw new NotImplementedException();
        }

        private int GetLevelID()
        {
            return loadGameDataParams.NewLevel;
        }

        private void OnEnable()
        {
            SubscribeEvents();
        }

        private void SubscribeEvents()
        {
            CoreGameSignals.Instance.onPlay += OnPlay;
            CoreGameSignals.Instance.onPlay += OnReset;
        }

       

        private void UnsubscribeEvents()
        {
            CoreGameSignals.Instance.onPlay -= OnPlay;
            CoreGameSignals.Instance.onPlay -= OnReset;
        }

       
        private void OnDisable()
        {
            UnsubscribeEvents();
        }

        private void OnPlay()
        {

        }
        private void OnReset()
        {

        }






    }
}
