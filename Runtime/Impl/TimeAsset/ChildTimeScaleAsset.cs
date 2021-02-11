using System;
using System.Collections;
using UnityEngine;

namespace ChronoLayer.Impl
{
    /// <summary>
    /// 子要素となるTimeScale
    /// </summary>
    public class ChildTimeScaleAsset : TimeScaleAsset
    {
        //=========================================
        // Field
        //=========================================
        [SerializeField] private TimeScaleAsset m_parent = default;
        [SerializeField] private float m_initialScale = 1f;
        [NonSerialized] private float m_localScale = 1f;

        //=========================================
        // Property
        //=========================================
        public override float LocalScale
        {
            get => m_localScale;
            set => m_localScale = value;
        }

        public override float TimeScale
        {
            get
            {
                if (m_parent)
                {
                    return m_parent.TimeScale * LocalScale;
                }
                return 1f;
            }
        }

        public override float DeltaTime
        {
            get
            {
                if (m_parent)
                {
                    return m_parent.DeltaTime * LocalScale;
                }
                return 0f;
            }
        }


        //=========================================
        // Method
        //=========================================
        private void OnValidate()
        {
            LocalScale = m_initialScale;
        }
    }
}