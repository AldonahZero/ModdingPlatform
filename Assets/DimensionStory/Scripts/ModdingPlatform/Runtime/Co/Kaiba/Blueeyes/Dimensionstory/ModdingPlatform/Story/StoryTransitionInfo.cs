using UnityEngine;

namespace Co.Kaiba.Blueeyes.Dimensionstory.ModdingPlatform.Story
{
    public struct StoryTransitionInfo
    {
        public bool IsName(string name)
        {
            return Animator.StringToHash(name) == m_Name || Animator.StringToHash(name) == m_FullPath;
        }

        public bool IsUserName(string name)
        {
            return Animator.StringToHash(name) == m_UserName;
        }

        public int fullPathHash
        {
            get
            {
                return m_FullPath;
            }
        }

        public int nameHash
        {
            get
            {
                return m_Name;
            }
        }

        public int userNameHash
        {
            get
            {
                return m_UserName;
            }
        }

        public float normalizedTime
        {
            get
            {
                return m_NormalizedTime;
            }
        }

        public bool anyState
        {
            get
            {
                return m_AnyState;
            }
        }

        public bool entry
        {
            get
            {
                return (m_TransitionType & 2) != 0;
            }
        }

        public bool exit
        {
            get
            {
                return (m_TransitionType & 4) != 0;
            }
        }

        private int m_FullPath;

        private int m_UserName;

        private int m_Name;

        private float m_NormalizedTime;

        private bool m_AnyState;

        private int m_TransitionType;
    }
}
