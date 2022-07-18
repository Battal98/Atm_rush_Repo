using System;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public struct LoadGameDataParams
    {
        public int NewTotalWealth;
        public int NewStackLevel;
        public int NewInCome;
        public int NewLevel;
        //public bool SFX;
        //public bool VFX;
        public List<GameObject> NewShop;//Character ID
    }
}
