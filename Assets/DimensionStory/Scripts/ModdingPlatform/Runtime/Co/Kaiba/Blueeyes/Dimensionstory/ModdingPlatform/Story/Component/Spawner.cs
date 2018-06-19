using Co.Kaiba.Blueeyes.Dimensionstory.ModdingPlatform.UI;
using UnityEngine;

namespace Co.Kaiba.Blueeyes.Dimensionstory.ModdingPlatform.Story.Component
{
    public class Spawner : Component
    {
        [Spawnable]
        public string Spawnable;
        public RuntimeAnimatorController AnimatorController;
        public string SpawnPos;
        public string Id;
    }
}
