using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Data;

namespace Controlers
{
    public class LoadDataController : MonoBehaviour
    {
        #region Self Veriables

        #region Privete Veriables
        private LoadGameDataParams saveDataParams;
        int dd;
        #endregion

        #endregion

        public void LoadData()
        {
            if (saveDataParams.NewLevel >= 0)
            {
                ES3.Load("Level", saveDataParams.NewLevel);
            }

            if (saveDataParams.NewTotalWealth >= 0) ES3.Load("TotalWealth", saveDataParams.NewTotalWealth);
            if (saveDataParams.NewStackLevel >= 0) ES3.Load("StackLevel", saveDataParams.NewStackLevel);
            if (saveDataParams.NewInCome >= 0) ES3.Load("NewInCome", saveDataParams.NewInCome);
          


            //if (saveDataParams.SFX != null) ES3.Save("SFX", saveDataParams.SFX);
            //if (saveDataParams.VFX != null) ES3.Save("VFX", saveDataParams.VFX);

        }
    } 
}
