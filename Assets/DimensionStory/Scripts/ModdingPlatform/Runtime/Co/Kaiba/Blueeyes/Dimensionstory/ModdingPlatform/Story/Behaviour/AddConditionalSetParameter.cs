namespace Co.Kaiba.Blueeyes.Dimensionstory.ModdingPlatform.Story.Behaviour
{
    public abstract class AddConditionalSetParameter : RuntimeStoryStateMachineBehaviour
    {
        public string idInStory;
        public string parameter;
        public StoryControllerParameterType parameterType;
        public float floatValue;
        public int intValue;
        public bool boolValue;
    }
}
