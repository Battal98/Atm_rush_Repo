using Controller;
using Enums;
using Signals;
using UnityEngine;
using Data.ValueObject;
using Data.UnityObject;

namespace Managers
{
    public class UIManager : MonoBehaviour
    {

        #region Self Variables

        #region Public Variables
        [Header("Datas")]
        public StackButtonData StackButtonData;
        public IncomeButtonData IncomeButtonData;
        #endregion

        #region Serialized Variables
        [Space]
        [SerializeField] 
        private UIPanelController uiPanelController;

        [SerializeField] 
        private LevelPanelController levelPanelController;

        [SerializeField]
        private MoneyPanelController moneyPanelController;

        [SerializeField]
        private StackButtonController stackButtonController;   
        
        [SerializeField]
        private IncomeButtonController incomeButtonController;

        #endregion

        #region Private Variables

        private int _stackButtonLevel;

        #endregion

        #endregion

        private void Awake()
        {
            /*_stackButtonLevel = GetStackButtonLevel();
            StackButtonData = GetStackButtonData();*/
            OnSetStackButtonText(StackButtonData.StackButtonPrize, StackButtonData.StackButtonLevelCount);
            OnSetIncomeButtonText(IncomeButtonData.IncomeButtonPrize, IncomeButtonData.IncomeButtonLevelCount);
        }
/*
        private int GetStackButtonLevel()
        {
            if (!ES3.FileExists()) return 0;
            return ES3.KeyExists("StackLevel") ? ES3.Load<int> ("StackLevel") : 0;
        }
        private StackButtonData GetStackButtonData()
        {
            var newStackButtonLevelData = _stackButtonLevel % Resources.Load<CD_StackButton>("Data/CD_StackButton").StackButtonData.StackButtonLevelCount;
            return Resources.Load<CD_StackButton>("Data/CD_StackButton").StackButtonData;
        }
*/
        #region Event Subscriptions

        private void OnEnable()
        {
            SubscribeEvents();
        }

        private void SubscribeEvents()
        {
            UISignals.Instance.onOpenPanel += OnOpenPanel;
            UISignals.Instance.onClosePanel += OnClosePanel;
            UISignals.Instance.onSetLevelText += OnSetLevelText;
            UISignals.Instance.onSetMoneyText += OnSetMoneyText;
            UISignals.Instance.onSetStackPrizeAndLevelText += OnSetStackButtonText;
            UISignals.Instance.onSetIncomePrizeAndLevelText += OnSetIncomeButtonText;

            #region CoreGameSignals Subscribetion

            // CoreGameSignals Came here with onplay, onlevelfailed, onlevelSuccess

            #endregion

        }

        private void UnsubscribeEvents()
        {
            UISignals.Instance.onOpenPanel -= OnOpenPanel;
            UISignals.Instance.onClosePanel -= OnClosePanel;
            UISignals.Instance.onSetLevelText -= OnSetLevelText;
            UISignals.Instance.onSetMoneyText -= OnSetMoneyText;
            UISignals.Instance.onSetStackPrizeAndLevelText -= OnSetStackButtonText;
            UISignals.Instance.onSetIncomePrizeAndLevelText -= OnSetIncomeButtonText;

            #region CoreGameSignals Unsubscribetion

            // CoreGameSignals Came here with onplay, onlevelfailed, onlevelSuccess

            #endregion
        }

        private void OnDisable()
        {
            UnsubscribeEvents();
        }

        #endregion

        private void OnOpenPanel(UIPanels panelParam)
        {
            uiPanelController.OpenPanel(panelParam);
        }

        private void OnClosePanel(UIPanels panelParam)
        {
            uiPanelController.ClosePanel(panelParam);
        }


        private void OnSetLevelText(int value)
        {
            levelPanelController.SetLevelText(value);
        }

        private void OnSetMoneyText(int value)
        {
            moneyPanelController.SetMoneyText(value);
        }

        private void OnSetStackButtonText(int _prizeValue, int _levelValue)
        {
            stackButtonController.SetStackPrizeAndLevelText(_prizeValue, _levelValue);
        }        
        private void OnSetIncomeButtonText(int _prizeValue, int _levelValue)
        {
           incomeButtonController.SetIncomePrizeAndLevelText(_prizeValue, _levelValue);
        }

        private void OnPlay()
        {
            UISignals.Instance.onClosePanel?.Invoke(UIPanels.StartPanel);
        }

        private void OnLevelFailed()
        {
            UISignals.Instance.onClosePanel?.Invoke(UIPanels.LevelPanel);
            UISignals.Instance.onOpenPanel?.Invoke(UIPanels.FailPanel);
        }

        private void OnLevelSuccessful()
        {
            UISignals.Instance.onClosePanel?.Invoke(UIPanels.LevelPanel);
            UISignals.Instance.onOpenPanel?.Invoke(UIPanels.WinPanel);
        }

        private void SetStackPrizeandLevelIndexIncrease()
        {
            if (StackButtonData.StackButtonPrize >= 0)
            {
                StackButtonData.StackButtonLevelCount++;
                StackButtonData.StackButtonPrize += 100;
            }
        }

        private void SetIncomePrizeAndLevelText()
        {
            if (IncomeButtonData.IncomeButtonPrize >= 0)
            {
                IncomeButtonData.IncomeButtonLevelCount++;
                IncomeButtonData.IncomeButtonPrize += 100;
            }
        }

        public void ClickIncomeButton()
        {
            //stackSignals invoke 
            SetIncomePrizeAndLevelText();
            UISignals.Instance.onSetIncomePrizeAndLevelText?.Invoke(IncomeButtonData.IncomeButtonPrize, IncomeButtonData.IncomeButtonLevelCount);
        }

        public void ClickStackButton()
        {
            SetStackPrizeandLevelIndexIncrease();
            UISignals.Instance.onSetStackPrizeAndLevelText?.Invoke(StackButtonData.StackButtonPrize, StackButtonData.StackButtonLevelCount);
        }

        public void OnClickStoreButton()
        {
            UISignals.Instance.onClosePanel?.Invoke(UIPanels.StartPanel);
            UISignals.Instance.onOpenPanel?.Invoke(UIPanels.StorePanel);
        }

        public void OnClickCloseButton(GameObject _closeButtonParentPanel)
        {
            UISignals.Instance.onOpenPanel.Invoke(UIPanels.StartPanel);
            _closeButtonParentPanel.SetActive(false);
        }


        public void Play()
        {
            //CoreGameSignals onplay Invoke here
        }

        public void NextLevel()
        {
            //CoreGameSignals onnextlevel Invoke here
            UISignals.Instance.onClosePanel?.Invoke(UIPanels.WinPanel);
            UISignals.Instance.onOpenPanel?.Invoke(UIPanels.StartPanel);
        }

        public void RestartLevel()
        {
            //CoreGameSignals onrestart Invoke here
            UISignals.Instance.onClosePanel?.Invoke(UIPanels.FailPanel);
            UISignals.Instance.onOpenPanel?.Invoke(UIPanels.StartPanel);
        }
    }
}