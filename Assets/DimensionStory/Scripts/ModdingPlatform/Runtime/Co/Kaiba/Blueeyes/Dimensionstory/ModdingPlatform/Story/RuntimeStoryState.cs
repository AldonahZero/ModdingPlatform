using System;
using Newtonsoft.Json;
using UnityEngine;

namespace Co.Kaiba.Blueeyes.Dimensionstory.ModdingPlatform.Story
{
    public class RuntimeStoryState : RuntimeStoryBase
    {
        public string id
        {
            get
            {
                return m_Id;
            }
            set
            {
                m_Id = value;
            }
        }

        public int nameHash
        {
            get
            {
                return Animator.StringToHash(name); // TODO
            }
        }

        [JsonIgnore]
        public Motion motion
        {
            get
            {
                return m_Motion;
            }
            set
            {
                m_Motion = value;
            }
        }

        public float speed
        {
            get
            {
                return m_Speed;
            }
            set
            {
                m_Speed = value;
            }
        }

        public float cycleOffset
        {
            get
            {
                return m_CycleOffset;
            }
            set
            {
                m_CycleOffset = value;
            }
        }

        public bool mirror
        {
            get
            {
                return m_Mirror;
            }
            set
            {
                m_Mirror = value;
            }
        }

        public bool iKOnFeet
        {
            get
            {
                return m_IKOnFeet;
            }
            set
            {
                m_IKOnFeet = value;
            }
        }

        public bool writeDefaultValues
        {
            get
            {
                return m_WriteDefaultValues;
            }
            set
            {
                m_WriteDefaultValues = value;
            }
        }

        public string tag
        {
            get
            {
                return m_Tag;
            }
            set
            {
                m_Tag = value;
            }
        }

        public string speedParameter
        {
            get
            {
                return m_SpeedParameter;
            }
            set
            {
                m_SpeedParameter = value;
            }
        }

        public string cycleOffsetParameter
        {
            get
            {
                return m_CycleOffsetParameter;
            }
            set
            {
                m_CycleOffsetParameter = value;
            }
        }

        public string mirrorParameter
        {
            get
            {
                return m_MirrorParameter;
            }
            set
            {
                m_MirrorParameter = value;
            }
        }

        public float timeParameter
        {
            get
            {
                return m_TimeParameter;
            }
            set
            {
                m_TimeParameter = value;
            }
        }

        public bool speedParameterActive
        {
            get
            {
                return m_SpeedParameterActive;
            }
            set
            {
                m_SpeedParameterActive = value;
            }
        }

        public bool cycleOffsetParameterActive
        {
            get
            {
                return m_CycleOffsetParameterActive;
            }
            set
            {
                m_CycleOffsetParameterActive = value;
            }
        }

        public bool mirrorParameterActive
        {
            get
            {
                return m_MirrorParameterActive;
            }
            set
            {
                m_MirrorParameterActive = value;
            }
        }

        public bool timeParameterActive
        {
            get
            {
                return m_TimeParameterActive;
            }
            set
            {
                m_TimeParameterActive = value;
            }
        }

        public RuntimeStoryStateTransition[] transitions
        {
            get
            {
                return m_Transitions;
            }
            set
            {
                m_Transitions = value;
            }
        }

        public RuntimeStoryStateMachineBehaviour[] behaviours
        {
            get
            {
                return m_Behaviours;
            }
            set
            {
                m_Behaviours = value;
            }
        }

        public int selectedStoryStateMachineBehaviour
        {
            get
            {
                return m_SelectedStoryStateMachineBehaviour;
            }
            set
            {
                m_SelectedStoryStateMachineBehaviour = value;
            }
        }

        [SerializeField]
        internal string m_Id = Guid.NewGuid().ToString();
        [SerializeField]
        internal Motion m_Motion;
        [SerializeField]
        internal float m_Speed;
        [SerializeField]
        internal float m_CycleOffset;
        [SerializeField]
        internal bool m_Mirror;
        [SerializeField]
        internal bool m_IKOnFeet;
        [SerializeField]
        internal bool m_WriteDefaultValues;
        [SerializeField]
        internal string m_Tag;
        [SerializeField]
        internal string m_SpeedParameter;
        [SerializeField]
        internal string m_CycleOffsetParameter;
        [SerializeField]
        internal string m_MirrorParameter;
        [SerializeField]
        internal float m_TimeParameter;
        [SerializeField]
        internal bool m_SpeedParameterActive;
        [SerializeField]
        internal bool m_CycleOffsetParameterActive;
        [SerializeField]
        internal bool m_MirrorParameterActive;
        [SerializeField]
        internal bool m_TimeParameterActive;
        [SerializeField]
        internal RuntimeStoryStateTransition[] m_Transitions = new RuntimeStoryStateTransition[0];
        [SerializeField]
        internal RuntimeStoryStateMachineBehaviour[] m_Behaviours = new RuntimeStoryStateMachineBehaviour[0];
        [SerializeField]
        internal int m_SelectedStoryStateMachineBehaviour;
    }
}
