using System;
using System.Collections;
using UnityEngine;

namespace ChronoLayer
{
    /// <summary>
    /// TimeScaleアセットの影響を与えるためのBehaviour
    /// </summary>
    public abstract class TimeInjectionBehaviour : MonoBehaviour
    {
        //=========================================
        // SerializeField
        //=========================================
        [SerializeField] private TimeScaleAsset m_time = default;

        //=========================================
        // Method
        //=========================================
        private void Update()
        {
            if (m_time)
            {
                ScaledTimeUpdate( m_time );
            }
        }

        protected abstract void ScaledTimeUpdate(ITimeScale time);
    }
}