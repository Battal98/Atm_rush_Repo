using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Controller
{
    public class LevelPanelController : MonoBehaviour
    {
        #region Self Variables

        #region Serialized Variables

        [SerializeField] 
        private TextMeshProUGUI levelText;

        #endregion

        #endregion


        public void SetLevelText(int value)
        {
            levelText.text = (value + 1).ToString();
        }

    }
}