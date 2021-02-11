using System.Collections;
using UnityEngine;

namespace ChronoLayer.Impl
{
    /// <summary>
    /// UnscaledTimeで参照するためのもの
    /// </summary>
    public sealed class UnscaledTimeScaleAsset : TimeScaleAsset
    {
        //======================================
        // Property
        //======================================
        public override float LocalScale {
            get => 1f;
            set { } 
        }

        public override float TimeScale => 1f;

        public override float DeltaTime => Time.unscaledDeltaTime;
    }
}