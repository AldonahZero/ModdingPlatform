using Newtonsoft.Json;
using UnityEngine;

namespace Co.Kaiba.Blueeyes.Dimensionstory.ModdingPlatform.Story.Config
{
    [CreateAssetMenu(fileName = "Skill", menuName = "Modding/Skill")]
    public class SkillTemplate : ScriptableObject
    {
        public string SkillName;
        public string[] States;
        public float[] Durations;
        public bool RandomPosition;
        public float RandomRadius;
        [JsonIgnore]
        public Sprite Icon;
        public float ColdDown;
    }
}
