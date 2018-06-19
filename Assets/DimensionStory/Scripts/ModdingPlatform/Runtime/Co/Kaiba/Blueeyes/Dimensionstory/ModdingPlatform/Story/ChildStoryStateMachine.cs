using System;
using Newtonsoft.Json;
using UnityEngine;

namespace Co.Kaiba.Blueeyes.Dimensionstory.ModdingPlatform.Story
{
    [Serializable]
    public struct ChildStoryStateMachine
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
        public Vector3 position
        {
            get
            {
                return m_Position;
            }
            set
            {
                m_Position = value;
            }
        }

        [SerializeField]
        private RuntimeStoryStateMachine m_StateMachine;

        [SerializeField]
        private Vector3 m_Position;
    }
}
