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
        public UnityAction<SaveGameDataParams> onSaveGameData = delegate { };
        public UnityAction<LoadGameDataParams> onLoadGameData = delegate { };
        
    } 
}
