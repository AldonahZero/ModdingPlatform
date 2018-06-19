using System;
using UnityEngine;

namespace Co.Kaiba.Blueeyes.Dimensionstory.ModdingPlatform.Story.Component
{
    public class Spawnable : MonoBehaviour
    {
        public string Id = Guid.NewGuid().ToString();
        public string Name;
    }
}
