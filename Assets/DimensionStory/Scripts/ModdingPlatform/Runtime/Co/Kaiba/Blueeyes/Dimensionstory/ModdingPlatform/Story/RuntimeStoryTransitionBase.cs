using Newtonsoft.Json;
using UnityEngine;

namespace Co.Kaiba.Blueeyes.Dimensionstory.ModdingPlatform.Story
{
    public class RuntimeStoryTransitionBase : RuntimeStoryBase
    {
        public bool solo
        {
            get
            {
                return m_Solo;
            }
            set
            {
                m_Solo = value;
            }
        }

        public bool mute
        {
            get
            {
                return m_Mute;
            }
            set
            {
                m_Mute = value;
            }
        }

        public bool isExit
        {
            get
            {
                return m_IsExit;
            }
            set
            {
                m_IsExit = value;
            }
        }

        [JsonIgnore]
        public RuntimeStoryStateMachine destinationStateMachine
        {
            get
            {
                return m_DestinationStateMachine;
            }
            set
            {
                m_DestinationStateMachine = value;
            }
        }

        public string destinationStateMachineId
        {
            get
            {
                return destinationStateMachine ? destinationStateMachine.id : null;
            }
        }

        [JsonIgnore]
        public RuntimeStoryState destinationState
        {
            get
            {
                return m_DestinationState;
            }
            set
            {
                m_DestinationState = value;
            }
        }

        public string destinationStateId
        {
            get
            {
                return destinationState ? destinationState.id : null;
            }
        }

        public StoryCondition[] conditions
        {
            get
            {
                return m_Conditions;
            }
            set
            {
                m_Conditions = value;
            }
        }

        [SerializeField]
        internal bool m_Solo;
        [SerializeField]
        internal bool m_Mute;
        [SerializeField]
        internal bool m_IsExit;
        [SerializeField]
        internal RuntimeStoryStateMachine m_DestinationStateMachine;
        [SerializeField]
        internal RuntimeStoryState m_DestinationState;
        [SerializeField]
        internal StoryCondition[] m_Conditions = new StoryCondition[0];
    }
}
