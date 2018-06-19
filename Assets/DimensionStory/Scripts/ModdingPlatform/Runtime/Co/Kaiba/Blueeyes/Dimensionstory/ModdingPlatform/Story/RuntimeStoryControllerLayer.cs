using Newtonsoft.Json;
using UnityEngine;

namespace Co.Kaiba.Blueeyes.Dimensionstory.ModdingPlatform.Story
{
    public class RuntimeStoryControllerLayer : RuntimeStoryBase
    {
        public RuntimeStoryStateMachine stateMachine
        {
            get
            {
                return m_StateMachine;
            }
            set
            {
                m_StateMachine = value;
            }
        }

        [JsonIgnore]
        public AvatarMask avatarMask
        {
            get
            {
                return m_AvatarMask;
            }
            set
            {
                m_AvatarMask = value;
            }
        }

        public StoryStateMotionPair[] motions
        {
            get
            {
                return m_Motions;
            }
            set
            {
                m_Motions = value;
            }
        }

        public StoryStateBehavioursPair[] behaviours
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

        public StoryLayerBlendingMode blendingMode
        {
            get
            {
                return m_BlendingMode;
            }
            set
            {
                m_BlendingMode = value;
            }
        }

        public int syncedLayerIndex
        {
            get
            {
                return m_SyncedLayerIndex;
            }
            set
            {
                m_SyncedLayerIndex = value;
            }
        }

        public bool iKPass
        {
            get
            {
                return m_IKPass;
            }
            set
            {
                m_IKPass = value;
            }
        }

        public float defaultWeight
        {
            get
            {
                return m_DefaultWeight;
            }
            set
            {
                m_DefaultWeight = value;
            }
        }

        public bool syncedLayerAffectsTiming
        {
            get
            {
                return m_SyncedLayerAffectsTiming;
            }
            set
            {
                m_SyncedLayerAffectsTiming = value;
            }
        }

        [SerializeField]
        internal RuntimeStoryStateMachine m_StateMachine;
        [SerializeField]
        internal AvatarMask m_AvatarMask;
        [SerializeField]
        internal StoryStateMotionPair[] m_Motions = new StoryStateMotionPair[0];
        [SerializeField]
        internal StoryStateBehavioursPair[] m_Behaviours = new StoryStateBehavioursPair[0];
        [SerializeField]
        internal StoryLayerBlendingMode m_BlendingMode;
        [SerializeField]
        internal int m_SyncedLayerIndex = -1;
        [SerializeField]
        internal bool m_IKPass;
        [SerializeField]
        internal float m_DefaultWeight;
        [SerializeField]
        internal bool m_SyncedLayerAffectsTiming;
    }
}
