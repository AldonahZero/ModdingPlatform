using UnityEngine;

namespace Co.Kaiba.Blueeyes.Dimensionstory.Util
{
    public class SingletonUtil<T> : MonoBehaviour where T : SingletonUtil<T>
    {
        public static T Instance { get; private set; }

        protected virtual void Awake()
        {
            if (!Instance)
                Instance = this as T;
        }

        protected virtual void OnEnable()
        {
            if (!Instance)
                Instance = this as T;
        }

        protected virtual void OnDestroy()
        {
            if (Instance == this)
                Instance = null;
        }
    }
}
