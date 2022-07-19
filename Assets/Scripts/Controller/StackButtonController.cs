using UnityEngine;
using TMPro;

public class StackButtonController : MonoBehaviour
{
    #region Self Variables

    #region Public Variables

    public int StackLevelCount = 1;

    #endregion

    #region Serialized Variables

    [SerializeField]
    private TextMeshProUGUI stackLevelText;

    [SerializeField]
    private int Prize = 100;

    #endregion

    #endregion


    public void SetStackLevelText(int value)
    {
        stackLevelText.text = (value).ToString();
    }

    public void SetStackPrizeandLevelIndex()
    {
        if (Prize >= 0)
        {
            StackLevelCount++;
            Prize += 100;
        }
    }
}
