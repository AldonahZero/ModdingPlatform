namespace Co.Kaiba.Blueeyes.Dimensionstory.ModdingPlatform.Story.Behaviour
{
    public class CrossFade : RuntimeStoryStateMachineBehaviour
    {
        public string idInStory;
        public string animation;
        public float transitionDuration;
        public int layer = -1;
        public bool legacy;
    }
}