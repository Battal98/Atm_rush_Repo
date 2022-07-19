using UnityEngine;
using TMPro;

namespace Controllers
{
    public class StackButtonController : MonoBehaviour
    {
        #region Self Variables

        #region Serialized Variables

        [SerializeField]
        private TextMeshProUGUI stackLevelText;
        [SerializeField]
        private TextMeshProUGUI stackPrizeText;

        #endregion

        #endregion


        public void SetStackPrizeAndLevelText(int _prizeValue, int _levelValue)
        {
            stackPrizeText.text = (_prizeValue).ToString() + "$";
            stackLevelText.text = "Level " + (_levelValue).ToString();
        }

    }
}
