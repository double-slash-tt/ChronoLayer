using UnityEngine;

namespace ChronoLayer
{
    /// <summary>
    /// TimeScaleを管理するアセット
    /// </summary>
    public abstract class TimeScaleAsset : ScriptableObject, ITimeScale, ITimeScaleOverride
    {
        //=======================================
        // Property
        //=======================================
        
        /// <summary>
        /// このレイヤーにおけるTimeScale(0 - 1)
        /// </summary>
        public abstract float LocalScale { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public abstract float TimeScale { get; }

        public abstract float DeltaTime { get; }
    }
}