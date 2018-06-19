using System;
using Co.Kaiba.Blueeyes.Dimensionstory.ModdingPlatform.UI;
using UnityEngine;

namespace Co.Kaiba.Blueeyes.Dimensionstory.ModdingPlatform.Story
{
    public partial class RuntimeStoryController : RuntimeStoryBase
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

        public string storyName
        {
            get
            {
                return m_StoryName;
            }
            set
            {
                m_StoryName = value;
            }
        }

        public bool exclusively
        {
            get
            {
                return m_Exclusively;
            }
            set
            {
                m_Exclusively = value;
            }
        }

        public string readyText
        {
            get
            {
                return m_ReadyText;
            }
            set
            {
                m_ReadyText = value;
            }
        }

        public string worldLine
        {
            get
            {
                return m_WorldLine;
            }
            set
            {
                m_WorldLine = value;
            }
        }

        public string[] gameCharacters
        {
            get
            {
                return m_GameCharacters;
            }
            set
            {
                m_GameCharacters = value;
            }
        }

        public RuntimeStoryControllerLayer[] layers
        {
            get
            {
                return m_Layers;
            }
            set
            {
                m_Layers = value;
            }
        }

        public RuntimeStoryControllerParameter[] parameters
        {
            get
            {
                return m_Parameters;
            }
            set
            {
                m_Parameters = value;
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
        internal string m_Id = Guid.NewGuid().ToString();
        [SerializeField]
        internal string m_StoryName;
        [SerializeField]
        internal bool m_Exclusively;
        [SerializeField]
        internal string m_ReadyText;
        [SerializeField]
        [WorldLine]
        internal string m_WorldLine;
        [SerializeField]
        [GameCharacter]
        internal string[] m_GameCharacters;
        [SerializeField]
        internal RuntimeStoryControllerLayer[] m_Layers = new RuntimeStoryControllerLayer[0];
        [SerializeField]
        internal RuntimeStoryControllerParameter[] m_Parameters = new RuntimeStoryControllerParameter[0];
        [SerializeField]
        internal StoryCondition[] m_Conditions = new StoryCondition[0];
    }
}
