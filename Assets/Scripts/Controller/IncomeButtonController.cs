using UnityEngine;
using TMPro;

public class IncomeButtonController : MonoBehaviour
{
    #region Self Variables

    #region Serialized Variables

    [SerializeField]
    private TextMeshProUGUI incomeLevelText;
    [SerializeField]
    private TextMeshProUGUI incomePrizeText;

    #endregion

    #endregion


    public void SetIncomePrizeAndLevelText(int _prizeValue, int _levelValue)
    {
        incomePrizeText.text = (_prizeValue).ToString() + "$";
        incomeLevelText.text = "Level " + (_levelValue).ToString();
    }
}
