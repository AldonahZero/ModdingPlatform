using UnityEngine;

namespace Co.Kaiba.Blueeyes.Dimensionstory.ModdingPlatform.Story
{
    public class RuntimeStoryControllerParameter : RuntimeStoryBase
    {
        public int nameHash
        {
            get
            {
                return Animator.StringToHash(name); // TODO
            }
        }

        public StoryControllerParameterType type
        {
            get
            {
                return m_Type;
            }
            set
            {
                m_Type = value;
            }
        }

        public float defaultFloat
        {
            get
            {
                return m_DefaultFloat;
            }
            set
            {
                m_DefaultFloat = value;
            }
        }

        public int defaultInt
        {
            get
            {
                return m_DefaultInt;
            }
            set
            {
                m_DefaultInt = value;
            }
        }

        public bool defaultBool
        {
            get
            {
                return m_DefaultBool;
            }
            set
            {
                m_DefaultBool = value;
            }
        }

        public RuntimeStoryTriggerBase trigger
        {
            get
            {
                return m_Trigger;
            }
            set
            {
                m_Trigger = value;
            }
        }

        public bool debug
        {
            get
            {
                return m_Debug;
            }
            set
            {
                m_Debug = value;
            }
        }

        public override bool Equals(object o)
        {
            RuntimeStoryControllerParameter runtimeStoryControllerParameter = o as RuntimeStoryControllerParameter;
            return runtimeStoryControllerParameter != null
                && name == runtimeStoryControllerParameter.name
                && m_Type == runtimeStoryControllerParameter.m_Type
                && m_DefaultFloat == runtimeStoryControllerParameter.m_DefaultFloat
                && m_DefaultInt == runtimeStoryControllerParameter.m_DefaultInt
                && m_DefaultBool == runtimeStoryControllerParameter.m_DefaultBool
                && m_Trigger == runtimeStoryControllerParameter.m_Trigger;
        }

        public override int GetHashCode()
        {
            return name.GetHashCode();
        }

        [SerializeField]
        internal StoryControllerParameterType m_Type;
        [SerializeField]
        internal float m_DefaultFloat;
        [SerializeField]
        internal int m_DefaultInt;
        [SerializeField]
        internal bool m_DefaultBool;
        [SerializeField]
        internal RuntimeStoryTriggerBase m_Trigger;
        [SerializeField]
        internal bool m_Debug;
    }
}