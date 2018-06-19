using UnityEngine;

namespace Co.Kaiba.Blueeyes.Dimensionstory.ModdingPlatform.Story.Component
{
    public class BattleStats : Component
    {
        public int Health;
        public Team Team;
        public GameObject TargetToAim;
    }

    public enum Team
    {
        Ally,
        Enemy
    }
}
