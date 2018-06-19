using Co.Kaiba.Blueeyes.Dimensionstory.ModdingPlatform.Story.Component;

namespace Co.Kaiba.Blueeyes.Dimensionstory.ModdingPlatform.Story.Behaviour
{
    public class AddMoveTowards : RuntimeStoryStateMachineBehaviour
    {
        public string idInStory;
        public string targetIdInStory;
        public MoveType moveType;
        public float duration;
        public float speed;
        public float startDistance;
        public float stopDistance;
        public bool destroyOnArrive;
        public string speedParameterName;
        public bool setSpeedParameter;
    }
}
