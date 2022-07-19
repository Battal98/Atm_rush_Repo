using Data;

namespace Controlers
{
    public class LoadDataController
    {
        #region Self Veriables

        #region Privete Veriables
        private LoadGameDataParams _loadDataParams;
        
        #endregion

        #endregion

        public void LoadData()
        {
            if (_loadDataParams.NewLevel >= 0)
            {
                ES3.Load("Level", _loadDataParams.NewLevel);
            }

            if (_loadDataParams.NewTotalWealth >= 0) ES3.Load("TotalWealth", _loadDataParams.NewTotalWealth);
            if (_loadDataParams.NewStackLevel >= 0) ES3.Load("StackLevel", _loadDataParams.NewStackLevel);
            if (_loadDataParams.NewStackLevel >= 0) ES3.Load("StackLevel", _loadDataParams.NewStackLevelPrice);
            if (_loadDataParams.NewInCome >= 0) ES3.Load("NewInCome", _loadDataParams.NewInCome);
            if (_loadDataParams.NewInCome >= 0) ES3.Load("NewInCome", _loadDataParams.NewInComePrice);



            //if (saveDataParams.SFX != null) ES3.Save("SFX", saveDataParams.SFX);
            //if (saveDataParams.VFX != null) ES3.Save("VFX", saveDataParams.VFX);

        }
    } 
}
