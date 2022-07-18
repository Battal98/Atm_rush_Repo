using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Keys;
namespace Controlers
{
    public class SaveDataController 
    {
        #region Self Variables

        #region Serialized Variables

        //[SerializeField] private List<GameObject> SaveObject;

        #endregion

        #endregion
        public void SaveEntry(SaveGameDataParams saveDataParams)
        {
            if (saveDataParams.Level >= 0)
            {
                ES3.Save("Level", saveDataParams.Level);
            }
            
            if (saveDataParams.TotalWealth >= 0) ES3.Save("TotalWealth", saveDataParams.TotalWealth);
            if (saveDataParams.StackLevel >= 0) ES3.Save("StackLevel", saveDataParams.StackLevel);
            if (saveDataParams.InCome >= 0) ES3.Save("StackLevel", saveDataParams.InCome);
            if (saveDataParams.Level >= 0) ES3.Save("StackLevel", saveDataParams.Level);


            //if (saveDataParams.SFX != null) ES3.Save("SFX", saveDataParams.SFX);
            //if (saveDataParams.VFX != null) ES3.Save("VFX", saveDataParams.VFX);

        }
    } 
}
