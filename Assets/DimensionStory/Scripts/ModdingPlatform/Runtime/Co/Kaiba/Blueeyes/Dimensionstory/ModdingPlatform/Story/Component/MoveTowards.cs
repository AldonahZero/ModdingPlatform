namespace Co.Kaiba.Blueeyes.Dimensionstory.ModdingPlatform.Story.Component
{
    public class MoveTowards : Component
    {
        public string TargetIdInStory;
        public MoveType MoveType;
        public float Duration;
        public float Speed;
        public float StartDistance;
        public float StopDistance;
        public bool DestroyOnArrive;
        public string SpeedParameterName;
        public bool SetSpeedParameter;
        public bool LookAt;
    }

    public enum MoveType
    {
        Time,
        Speed
    }
}
