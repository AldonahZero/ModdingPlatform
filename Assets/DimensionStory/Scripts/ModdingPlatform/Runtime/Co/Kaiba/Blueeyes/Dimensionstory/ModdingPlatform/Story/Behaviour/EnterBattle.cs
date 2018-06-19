using Co.Kaiba.Blueeyes.Dimensionstory.ModdingPlatform.Story.Config;
using Newtonsoft.Json;
using UnityEngine;

namespace Co.Kaiba.Blueeyes.Dimensionstory.ModdingPlatform.Story.Behaviour
{
    public class EnterBattle : RuntimeStoryStateMachineBehaviour
    {
        public int health;
        public SkillTemplate[] skillTemplates;
        [JsonIgnore]
        public GameObject[] effects;
    }
}
