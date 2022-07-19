using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Extentions;
using UnityEngine.Events;
using Data;

namespace Signals
{
    public class CoreGameSignals : MonoSingleton<CoreGameSignals>
    {
        public UnityAction onGameOpen = delegate { };
        public UnityAction onGameClose = delegate { };
        public UnityAction<bool> onGamePause = delegate { };
        public UnityAction onPlay=delegate { };
        public UnityAction OnReset=delegate { };
        public UnityAction onLevelFailed = delegate { };
        public UnityAction onLevelSuccessful = delegate { };
        public UnityAction onNextLevel = delegate { };
        public UnityAction onRestartLevel = delegate { };
        public UnityAction onLevelInitialize = delegate { };
        public UnityAction onClearActiveLevel = delegate { };
        //public UnityAction<SaveGameDataParams> onSaveGameData = delegate { };//TODO:SaveSignals açýlcak
        //public UnityAction<LoadGameDataParams> onLoadGameData = delegate { };

    } 
}
