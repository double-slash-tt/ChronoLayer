using System.Collections;
using UnityEngine;

namespace ChronoLayer.Impl
{
    /// <summary>
    /// デフォルトのTimeScaleを取得するもの
    /// </summary>
    [CreateAssetMenu(menuName = MenuName.TIME_SOURCE + nameof(OriginTimeScaleAsset))]
    public sealed class OriginTimeScaleAsset : TimeScaleAsset
    {
        //======================================
        // Property
        //======================================
        public override float LocalScale {
            get => Time.timeScale;
            set => Time.timeScale = value; 
        }

        public override float TimeScale => this.LocalScale;

        public override float DeltaTime => Time.deltaTime;
    }
}