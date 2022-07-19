using System;
using Controllers;
using Data.UnityObject;
using Data.ValueObject;
using Data.ValueObject
using Data.UnityObject;
using Keys;
using Signals;
using UnityEngine;
using UnityEngine.Events;

namespace Managers
{
    
}
public class PlayerManager : MonoBehaviour
{
    #region SelfVariables

    #region PrivateVariables

    

    #endregion

    #region SerializedVariables

    [SerializeField] private PlayerMovementController playerMovementController;
    [SerializeField] private PlayerPhysicsController playerPhysicsController;
    [SerializeField] private PlayerAnimationController playerAnimationController;
    [SerializeField] private PlayerTextController playerTextController;
    
    

    #endregion

    #region PublicVariables
    [Header("Player Data")] public PlayerData PlayerData;
    

    #endregion
    

    #endregion

    #region EventSubscription

    private void OnEnable()
    {
        SubscribeEvents();
    }
    private void OnDisable()
    {
        UnSubscribeEvents();
    }

    private void SubscribeEvents()
    {
        InputSignals.Instance.onInputTaken += OnActivateMovement();
        InputSignals.Instance.onInputReleased += OnDeactivateMovement();
        InputSignals.Instance.onInputDragged += OnGetInputValues();
        // CoreGameSignals.Instance.onPlay += OnPlay();
        // CoreGameSignals.Instance.onReset += OnReset();
        // CoreGameSignals.Instance.onLevelSuccessful+= OnLevelSuccessful();
        // CoreGameSignals.Instance.onLevelFailed+= OnLevelFailed();
        // CoreGameSignals.Instance.onStageAreaReached+= OnStageAreaReached();
        // CoreGameSignals.Instance.onStageAreaSuccessful+= OnStageAreaSuccessful();
    }

    
    private void UnSubscribeEvents()
    {
        InputSignals.Instance.onInputTaken -= OnActivateMovement();
        InputSignals.Instance.onInputReleased -= OnDeactivateMovement();
        InputSignals.Instance.onInputDragged -= OnGetInputValues();
        // CoreGameSignals.Instance.onPlay -= OnPlay();
        // CoreGameSignals.Instance.onReset -= OnReset();
        // CoreGameSignals.Instance.onLevelSuccessful-= OnLevelSuccessful();
        // CoreGameSignals.Instance.onLevelFailed-= OnLevelFailed();
        // CoreGameSignals.Instance.onStageAreaReached-= OnStageAreaReached();
        // CoreGameSignals.Instance.onStageAreaSuccessful-= OnStageAreaSuccessful();
    }

    #endregion
    private void Awake()
    {
        playerData = GetPlayerData();
    }

    private PlayerData GetPlayerData()=> Resources.Load<CD_Player>("Data/CD_Player").Data;

    #region SubscribedMethods
    private object OnPlay()
    {
        throw new NotImplementedException();
    }

    private UnityAction OnDeactivateMovement()
    {
        throw new NotImplementedException();
    }

    private UnityAction<HorizontalInputParams> OnGetInputValues()
    {
        throw new NotImplementedException();
    }

    private UnityAction OnActivateMovement()
    {
        throw new NotImplementedException();
    }
    private object OnReset()
    {
        throw new NotImplementedException();
    }

    #endregion
}
