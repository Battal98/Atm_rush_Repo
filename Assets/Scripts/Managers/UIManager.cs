using Controller;
using Enums;
using Signals;
using UnityEngine;

namespace Managers
{
    public class UIManager : MonoBehaviour
    {

        #region Self Variables

        #region Serialized Variables

        [SerializeField] 
        private UIPanelController uiPanelController;

        [SerializeField] 
        private LevelPanelController levelPanelController;

        [SerializeField]
        private MoneyPanelController moneyPanelController;

        [SerializeField]
        private StackButtonController stackButtonController;

        #endregion

        #endregion

        private void Awake()
        {
            
        }

        private StackButtonData GetStackButtonData()
        {
            return null;
        }

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
            UISignals.Instance.onSetStackLevelText += OnSetStackText;

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
            UISignals.Instance.onSetStackLevelText = OnSetStackText;

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

        private void OnSetStackText(int value)
        {
            stackButtonController.SetStackLevelText(value);
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
        
        public void ClickIncomeButton()
        {
            // Invoke UIsignal for change text 
                UISignals.Instance.onSetStackLevelText?.Invoke(stackButtonController.StackLevelCount);
            

        }

        public void OnClickStackCountButton()
        {

           // Invoke UIsignal for change text 
        }

        public void OnClickStoreButton()
        {
            UISignals.Instance.onClosePanel?.Invoke(UIPanels.StartPanel);
            UISignals.Instance.onOpenPanel?.Invoke(UIPanels.StorePanel);
        }

        public void OnClickStoreCloseButton(GameObject _closeButtonParentPanel)
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