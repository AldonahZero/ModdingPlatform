using Co.Kaiba.Blueeyes.Dimensionstory.ModdingPlatform.UI;
using Newtonsoft.Json;
using UnityEngine;

namespace Co.Kaiba.Blueeyes.Dimensionstory.ModdingPlatform.Story.Behaviour
{
    public class Talk : RuntimeStoryStateMachineBehaviour
    {
        [GameCharacter]
        public string gameCharacter;
        [Message]
        public string message;
        [JsonIgnore]
        public AudioClip voice;
        public string idInStory;
        public bool from;
    }
}
