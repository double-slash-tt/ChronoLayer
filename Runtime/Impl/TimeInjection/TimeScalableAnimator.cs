using System.Collections;
using UnityEngine;

namespace ChronoLayer
{
    /// <summary>
    /// TimeScaleを与えるAnimator
    /// </summary>
    [DisallowMultipleComponent]
    public sealed class TimeScalableAnimator : TimeInjectionBehaviour
    {
        //=======================================
        // Field
        //=======================================
        private Animator m_animator = default;

        //=======================================
        // Method
        //=======================================
        private void Start()
        {
            m_animator = GetComponent<Animator>();
        }
        protected override void ScaledTimeUpdate(ITimeScale time)
        {
            if (m_animator)
            {
                m_animator.speed = time.TimeScale;
            }
        }
    }
}