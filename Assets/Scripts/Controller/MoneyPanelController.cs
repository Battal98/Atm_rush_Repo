using TMPro;
using UnityEngine;

namespace Controllers
{
    public class MoneyPanelController : MonoBehaviour
    {
        #region Self Variables

        #region Serialized Variables

        [SerializeField]
        private TextMeshProUGUI moneyText;

        #endregion

        #endregion


        public void SetMoneyText(int value)
        {
            moneyText.text = (value).ToString();
        }

    }
}

