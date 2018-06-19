using Co.Kaiba.Blueeyes.Dimensionstory.ModdingPlatform.UI;

namespace Co.Kaiba.Blueeyes.Dimensionstory.ModdingPlatform.Story.Behaviour
{
    public class Chat : RuntimeStoryStateMachineBehaviour
    {
        public float delay = 1;
        [GameCharacter]
        public string gameCharacter;
        [Message]
        public string message;
        public bool from;
    }
}
