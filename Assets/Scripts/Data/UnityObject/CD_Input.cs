using Data.ValueObject;
using UnityEngine;

namespace Data.UnityObject
{
    [CreateAssetMenu(fileName = "ATMRush", menuName = "CD_Input", order = 0)]
    public class CD_Input : ScriptableObject
    {
        public InputData inputData;
    }
}