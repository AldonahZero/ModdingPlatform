using UnityEngine;

namespace Co.Kaiba.Blueeyes.Dimensionstory.ModdingPlatform.Story
{
    public struct StoryStateInfo
    {
        private int m_Name;
        private int m_Path;
        private int m_FullPath;
        private float m_NormalizedTime;
        private float m_Length;
        private float m_Speed;
        private float m_SpeedMultiplier;
        private int m_Tag;
        private int m_Loop;
        
        public int fullPathHash
        {
            get
            {
                return m_FullPath;
            }
        }
        
        public int shortNameHash
        {
            get
            {
                return m_Name;
            }
        }
        
        public float normalizedTime
        {
            get
            {
                return m_NormalizedTime;
            }
        }
        
        public float length
        {
            get
            {
                return m_Length;
            }
        }
        
        public float speed
        {
            get
            {
                return m_Speed;
            }
        }
        
        public float speedMultiplier
        {
            get
            {
                return m_SpeedMultiplier;
            }
        }
        
        public int tagHash
        {
            get
            {
                return m_Tag;
            }
        }
        
        public bool loop
        {
            get
            {
                return m_Loop != 0;
            }
        }

        public bool IsName(string name)
        {
            int hash = Animator.StringToHash(name);
            return hash == m_FullPath || hash == m_Name || hash == m_Path;
        }

        public bool IsTag(string tag)
        {
            return Animator.StringToHash(tag) == m_Tag;
        }
    }
}
