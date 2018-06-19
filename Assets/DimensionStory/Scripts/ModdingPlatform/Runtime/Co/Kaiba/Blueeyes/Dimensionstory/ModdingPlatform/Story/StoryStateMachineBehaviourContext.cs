using System;
using System.Runtime.InteropServices;
using Object = UnityEngine.Object;

namespace Co.Kaiba.Blueeyes.Dimensionstory.ModdingPlatform.Story
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public sealed class StoryStateMachineBehaviourContext
    {
        public RuntimeStoryController storyController;

        public Object animatorObject;

        public int layerIndex;
    }
}
