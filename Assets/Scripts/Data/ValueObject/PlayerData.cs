namespace Data.ValueObject
{
    public class PlayerData
    {
        private PlayerMovementData movementData;
    }

    public class PlayerMovementData
    {
        public float ForwardSpeed = 5;
        public float SidewaysSpeed = 2;
    }
}