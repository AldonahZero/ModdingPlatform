using UnityEngine;

namespace Co.Kaiba.Blueeyes.Dimensionstory.ModdingPlatform.Story
{
    public class RuntimeStoryLatLngTrigger : RuntimeStoryTriggerBase
    {
        public double latitude
        {
            get
            {
                return m_Latitude;
            }
            set
            {
                m_Latitude = value;
            }
        }

        public double longitude
        {
            get
            {
                return m_Longitude;
            }
            set
            {
                m_Longitude = value;
            }
        }

        public int radius
        {
            get
            {
                return m_Radius;
            }
            set
            {
                m_Radius = value;
            }
        }

        [SerializeField]
        private double m_Latitude;
        [SerializeField]
        private double m_Longitude;
        [SerializeField]
        private int m_Radius;
    }
}
