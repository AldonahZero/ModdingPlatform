using System;
using UnityEngine;

namespace Co.Kaiba.Blueeyes.Dimensionstory.ModdingPlatform.Story
{
    [Serializable]
    public struct StoryStateBehavioursPair
    {
        public RuntimeStoryState m_State;

        public StateMachineBehaviour[] m_Behaviours;
    }
}
