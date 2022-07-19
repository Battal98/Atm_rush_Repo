using Data;


namespace Controlers
{
    public class SaveDataController
    {
        #region Self Variables
        private SaveGameDataParams _saveDataParams;
        #region Serialized Variables

        //[SerializeField] private List<GameObject> SaveObject;

        #endregion

        #endregion
        public void SaveData()
        {
            if (_saveDataParams.Level >= 0)
            {
                ES3.Save("Level", _saveDataParams.Level);
            }
           
            if (_saveDataParams.TotalWealth >= 0) ES3.Save("TotalWealth", _saveDataParams.TotalWealth);
            if (_saveDataParams.StackLevel >= 0) ES3.Save("StackLevel", _saveDataParams.StackLevel);
            if (_saveDataParams.StackLevelPrice >= 0) ES3.Save("StackPrice", _saveDataParams.StackLevelPrice);
            if (_saveDataParams.InCome >= 0) ES3.Save("InCome", _saveDataParams.InCome);
            if (_saveDataParams.InComePrice >= 0) ES3.Save("InCome", _saveDataParams.InComePrice);



            //if (saveDataParams.SFX != null) ES3.Save("SFX", saveDataParams.SFX);
            //if (saveDataParams.VFX != null) ES3.Save("VFX", saveDataParams.VFX);

        }
    } 
}
