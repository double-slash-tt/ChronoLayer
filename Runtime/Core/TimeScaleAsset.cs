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
        /// 合計のTimeScale
        /// </summary>
        public abstract float TimeScale { get; }
        /// <summary>
        /// 合計のDeltaTime
        /// </summary>
        public abstract float DeltaTime { get; }
    }
}