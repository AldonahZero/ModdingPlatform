using Co.Kaiba.Blueeyes.Dimensionstory.ModdingPlatform.UI;
using Co.Kaiba.Blueeyes.Dimensionstory.ModdingPlatform.Weather;
using UnityEngine;

namespace Co.Kaiba.Blueeyes.Dimensionstory.ModdingPlatform.Story
{
    public class RuntimeStoryWeatherTrigger : RuntimeStoryTriggerBase
    {
        public AMapWeather AMapWeather
        {
            get
            {
                return _mAMapWeather;
            }
            set
            {
                _mAMapWeather = value;
            }
        }

        public AMapWeather0 AMapWeather0
        {
            get
            {
                return _mAMapWeather0;
            }
            set
            {
                _mAMapWeather0 = value;
            }
        }

        [SerializeField]
        [EnumFlags]
        private AMapWeather _mAMapWeather;
        [SerializeField]
        [EnumFlags]
        private AMapWeather0 _mAMapWeather0;
    }
}
