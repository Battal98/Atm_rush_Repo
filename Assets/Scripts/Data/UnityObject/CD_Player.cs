using UnityEngine;
using Data.ValueObject;


namespace Data.UnityObject
{
    [CreateAssetMenu(fileName = "ATMRush", menuName = "CD_Player", order = 0)]
    public class CD_Player : ScriptableObject
    {
        public PlayerData Data;
    }
}