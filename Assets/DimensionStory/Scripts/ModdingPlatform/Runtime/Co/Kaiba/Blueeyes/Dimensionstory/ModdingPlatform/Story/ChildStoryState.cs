using System;
using Newtonsoft.Json;
using UnityEngine;

namespace Co.Kaiba.Blueeyes.Dimensionstory.ModdingPlatform.Story
{
    [Serializable]
    public struct ChildStoryState
    {
        public RuntimeStoryState state
        {
            get
            {
                return m_State;
            }
            set
            {
                m_State = value;
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
        private RuntimeStoryState m_State;

        [SerializeField]
        private Vector3 m_Position;
    }
}
