using System;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    [Serializable]
    public struct SaveGameDataParams
    {
        public int TotalWealth;
        public int StackLevel;
        public int InCome;
        public int Level;
        //public bool SFX;
        //public bool VFX;
        public List<GameObject> Shop;//Character ID
    }
                                    

}