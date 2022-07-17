using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Extentions;
using UnityEngine.Events;

namespace Signals
{
    public class CoreGameSignals : MonoSingleton<CoreGameSignals>
    {
        public UnityAction onGameOpen = delegate { };
        public UnityAction onGameClose = delegate { };
        public UnityAction<bool> onGamePause = delegate { };




    } 
}
