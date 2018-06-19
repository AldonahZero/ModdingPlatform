using System;
using Newtonsoft.Json;
using UnityEngine;

namespace Co.Kaiba.Blueeyes.Dimensionstory.ModdingPlatform.Story
{
    public class RuntimeStoryStateMachine : RuntimeStoryBase
    {
        public string id
        {
            get
            {
                return m_Id;
            }
        }

        public ChildStoryState[] states
        {
            get
            {
                return m_States;
            }
            set
            {
                m_States = value;
            }
        }

        public ChildStoryStateMachine[] stateMachines
        {
            get
            {
                return m_StateMachines;
            }
            set
            {
                m_StateMachines = value;
            }
        }

        [JsonIgnore]
        public RuntimeStoryState defaultState
        {
            get
            {
                return m_DefaultState;
            }
            set
            {
                m_DefaultState = value;
            }
        }

        public string defaultStateId
        {
            get
            {
                return defaultState ? defaultState.id : null;
            }
        }

        [JsonIgnore]
        public Vector3 anyStatePosition
        {
            get
            {
                return m_AnyStatePosition;
            }
            set
            {
                m_AnyStatePosition = value;
            }
        }

        [JsonIgnore]
        public Vector3 entryPosition
        {
            get
            {
                return m_EntryPosition;
            }
            set
            {
                m_EntryPosition = value;
            }
        }

        [JsonIgnore]
        public Vector3 exitPosition
        {
            get
            {
                return m_ExitPosition;
            }
            set
            {
                m_ExitPosition = value;
            }
        }

        [JsonIgnore]
        public Vector3 parentStateMachinePosition
        {
            get
            {
                return m_ParentStateMachinePosition;
            }
            set
            {
                m_ParentStateMachinePosition = value;
            }
        }

        public RuntimeStoryStateTransition[] anyStateTransitions
        {
            get
            {
                return m_AnyStateTransitions;
            }
            set
            {
                m_AnyStateTransitions = value;
            }
        }

        public RuntimeStoryTransition[] entryTransitions
        {
            get
            {
                return m_EntryTransitions;
            }
            set
            {
                m_EntryTransitions = value;
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
        internal ChildStoryState[] m_States = new ChildStoryState[0];
        [SerializeField]
        internal ChildStoryStateMachine[] m_StateMachines = new ChildStoryStateMachine[0];
        [SerializeField]
        internal RuntimeStoryState m_DefaultState;
        [SerializeField]
        internal Vector3 m_AnyStatePosition = new Vector2(0, -100);
        [SerializeField]
        internal Vector3 m_EntryPosition;
        [SerializeField]
        internal Vector3 m_ExitPosition = new Vector2(750, 0);
        [SerializeField]
        internal Vector3 m_ParentStateMachinePosition;
        [SerializeField]
        internal RuntimeStoryStateTransition[] m_AnyStateTransitions = new RuntimeStoryStateTransition[0];
        [SerializeField]
        internal RuntimeStoryTransition[] m_EntryTransitions = new RuntimeStoryTransition[0];
        [SerializeField]
        internal RuntimeStoryStateMachineBehaviour[] m_Behaviours = new RuntimeStoryStateMachineBehaviour[0];
        [SerializeField]
        internal int m_SelectedStoryStateMachineBehaviour;
    }
}