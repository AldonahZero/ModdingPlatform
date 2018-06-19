using System;
using UnityEngine;

namespace Co.Kaiba.Blueeyes.Dimensionstory.ModdingPlatform.Story
{
    [Serializable]
    public struct StoryCondition
    {
        public StoryConditionMode mode
        {
            get
            {
                return m_ConditionMode;
            }
            set
            {
                m_ConditionMode = value;
            }
        }

        public string parameter
        {
            get
            {
                return m_ConditionEvent;
            }
            set
            {
                m_ConditionEvent = value;
            }
        }

        public float threshold
        {
            get
            {
                return m_EventTreshold;
            }
            set
            {
                m_EventTreshold = value;
            }
        }

        [SerializeField]
        private StoryConditionMode m_ConditionMode;
        [SerializeField]
        private string m_ConditionEvent;
        [SerializeField]
        private float m_EventTreshold;
    }
}
