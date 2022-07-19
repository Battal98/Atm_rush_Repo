using Data.ValueObject;
using UnityEngine;
using Keys;

namespace Controlers
{
    public class PlayerMovementController : MonoBehaviour
    {
        #region SelfVariables

        #region SerializedVariables

        

        #endregion

        #region PublicVariables

        

        #endregion

        #region PrivateVariables
        [Header("Movement Data")]private PlayerMovementData _movementData;
        private bool _isReadyToMove, _isReadyToPlay;
        private float _inputValue;
        private Vector2 _clampValues;
        #endregion
        #endregion

        public void SetMovementData(PlayerMovementData dataMovementData)
        {
            _movementData = dataMovementData;
        }

        void EnableMovement()
        {
            _isReadyToMove = true;
        }
        void DisableMovement()
        {
            _isReadyToMove = false;
        }
        void UpdateInputValue(HorizontalInputParams inputParam)
        {
            _inputValue=inputParam.XValue;
            _clampValues=inputParam.ClampValues;
        }
        public void IsReadyToPlay(bool state)
        {
            _isReadyToPlay = state;
        }
        private void FixedUpdate()
        {
            // if (_isReadyToPlay)
            // {
            //     if (_isReadyToMove)
            //     {
            //         Move();
            //     }
            //     else
            //     {
            //         StopSideways();
            //     }
            // }
            // else
            //     Stop();
        }
    }
}