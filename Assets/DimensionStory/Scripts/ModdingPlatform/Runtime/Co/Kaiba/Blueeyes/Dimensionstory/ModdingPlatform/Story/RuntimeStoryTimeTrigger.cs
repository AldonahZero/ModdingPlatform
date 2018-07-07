using UnityEngine;

namespace Co.Kaiba.Blueeyes.Dimensionstory.ModdingPlatform.Story
{
    public class RuntimeStoryTimeTrigger : RuntimeStoryTriggerBase
    {
        public RuntimeStoryTimeTriggerChildBase[] children
        {
            get
            {
                return m_Children;
            }
            set
            {
                m_Children = value;
            }
        }

        [SerializeField]
        private RuntimeStoryTimeTriggerChildBase[] m_Children = new RuntimeStoryTimeTriggerChildBase[0];
    }
}
