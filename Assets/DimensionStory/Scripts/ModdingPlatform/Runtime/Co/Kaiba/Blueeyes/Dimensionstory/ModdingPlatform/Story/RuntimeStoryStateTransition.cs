using UnityEngine;

namespace Co.Kaiba.Blueeyes.Dimensionstory.ModdingPlatform.Story
{
    public class RuntimeStoryStateTransition : RuntimeStoryTransitionBase
    {
        public float duration
        {
            get
            {
                return m_Duration;
            }
            set
            {
                m_Duration = value;
            }
        }

        public float offset
        {
            get
            {
                return m_Offset;
            }
            set
            {
                m_Offset = value;
            }
        }

        public StoryTransitionInterruptionSource interruptionSource
        {
            get
            {
                return m_InterruptionSource;
            }
            set
            {
                m_InterruptionSource = value;
            }
        }

        public bool orderedInterruption
        {
            get
            {
                return m_OrderedInterruption;
            }
            set
            {
                m_OrderedInterruption = value;
            }
        }

        public float exitTime
        {
            get
            {
                return m_ExitTime;
            }
            set
            {
                m_ExitTime = value;
            }
        }

        public bool hasExitTime
        {
            get
            {
                return m_HasExitTime;
            }
            set
            {
                m_HasExitTime = value;
            }
        }

        public bool hasFixedDuration
        {
            get
            {
                return m_HasFixedDuration;
            }
            set
            {
                m_HasFixedDuration = value;
            }
        }

        public bool canTransitionToSelf
        {
            get
            {
                return m_CanTransitionToSelf;
            }
            set
            {
                m_CanTransitionToSelf = value;
            }
        }

        [SerializeField]
        internal float m_Duration;
        [SerializeField]
        internal float m_Offset;
        [SerializeField]
        internal StoryTransitionInterruptionSource m_InterruptionSource;
        [SerializeField]
        internal bool m_OrderedInterruption;
        [SerializeField]
        internal float m_ExitTime;
        [SerializeField]
        internal bool m_HasExitTime;
        [SerializeField]
        internal bool m_HasFixedDuration;
        [SerializeField]
        internal bool m_CanTransitionToSelf;
    }
}
