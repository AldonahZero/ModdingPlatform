using System;
using UnityEngine;

namespace Co.Kaiba.Blueeyes.Dimensionstory.ModdingPlatform.Story
{
    public class RuntimeStoryStateMachineBehaviour : RuntimeStoryBase
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

        public bool disable
        {
            get { return m_Disable; }
            set { m_Disable = value; }
        }

        [SerializeField]
        internal string m_Id = Guid.NewGuid().ToString();
        [SerializeField]
        internal bool m_Disable;


        //public virtual void OnStoryStateEnter(Animator animator, StoryStateInfo stateInfo, int layerIndex)
        //{
        //}

        //public virtual void OnStoryStateUpdate(Animator animator, StoryStateInfo stateInfo, int layerIndex)
        //{
        //}

        //public virtual void OnStoryStateExit(Animator animator, StoryStateInfo stateInfo, int layerIndex)
        //{
        //}

        //public virtual void OnStoryStateMove(Animator animator, StoryStateInfo stateInfo, int layerIndex)
        //{
        //}

        //public virtual void OnStoryStateIK(Animator animator, StoryStateInfo stateInfo, int layerIndex)
        //{
        //}
        
        //public virtual void OnStoryStateMachineEnter(Animator animator, int stateMachinePathHash)
        //{
        //}
        
        //public virtual void OnStoryStateMachineExit(Animator animator, int stateMachinePathHash)
        //{
        //}

        //public virtual void OnStoryStateEnter(Animator animator, StoryStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller)
        //{
        //}

        //public virtual void OnStoryStateUpdate(Animator animator, StoryStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller)
        //{
        //}

        //public virtual void OnStoryStateExit(Animator animator, StoryStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller)
        //{
        //}

        //public virtual void OnStoryStateMove(Animator animator, StoryStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller)
        //{
        //}

        //public virtual void OnStoryStateIK(Animator animator, StoryStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller)
        //{
        //}

        //public virtual void OnStoryStateMachineEnter(Animator animator, int stateMachinePathHash, AnimatorControllerPlayable controller)
        //{
        //}

        //public virtual void OnStoryStateMachineExit(Animator animator, int stateMachinePathHash, AnimatorControllerPlayable controller)
        //{
        //}
    }
}
