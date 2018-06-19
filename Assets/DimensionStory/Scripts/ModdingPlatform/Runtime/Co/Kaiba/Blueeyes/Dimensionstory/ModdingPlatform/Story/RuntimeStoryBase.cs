using System;
using UnityEngine;

namespace Co.Kaiba.Blueeyes.Dimensionstory.ModdingPlatform.Story
{
    public class RuntimeStoryBase : ScriptableObject
    {
        [NonSerialized]
        public object m_Wrapper;

        [NonSerialized]
        public object m_Json;
    }
}
