using UnityEngine;

namespace Co.Kaiba.Blueeyes.Dimensionstory.ModdingPlatform.Story
{
    public class RuntimeStoryRateTrigger : RuntimeStoryTriggerBase
    {
        public float rate
        {
            get
            {
                return m_Rate;
            }
            set
            {
                m_Rate = value;
            }
        }

        [SerializeField]
        private float m_Rate;
    }
}
