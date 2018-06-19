using Newtonsoft.Json;
using UnityEngine;

namespace Co.Kaiba.Blueeyes.Dimensionstory.ModdingPlatform.Story.Behaviour
{
    public class Spawn : RuntimeStoryStateMachineBehaviour
    {
        [JsonIgnore]
        public GameObject go;
        public string idInStory;
    }
}
