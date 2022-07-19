using UnityEngine;
using Data.ValueObject;


namespace Data.UnityObject
{
    [CreateAssetMenu(fileName = "FILENAME", menuName = "MENUNAME", order = 0)]
    public class CD_Player : ScriptableObject
    {
        public PlayerData Data;
    }
}