using UnityEngine;

namespace Co.Kaiba.Blueeyes.Dimensionstory.ModdingPlatform.Story
{
    public class RuntimeStoryPlaceTrigger : RuntimeStoryTriggerBase
    {
        public string aMapKeywords
        {
            get
            {
                return m_AMapKeywords;
            }
            set
            {
                m_AMapKeywords = value;
            }
        }

        public string aMapTypes
        {
            get
            {
                return m_AMapTypes;
            }
            set
            {
                m_AMapTypes = value;
            }
        }

        public int radius
        {
            get
            {
                return m_Radius;
            }
            set
            {
                m_Radius = value;
            }
        }

        [SerializeField]
        private string m_AMapKeywords;
        [SerializeField]
        private string m_AMapTypes;
        [SerializeField]
        private int m_Radius;
    }
}
