using System.Collections;
using UnityEngine;

namespace ChronoLayer.Impl
{
    /// <summary>
    /// ParticleにTimeScaleを与える
    /// </summary>
    [DisallowMultipleComponent]
    public sealed class TimeScalableParticle : TimeInjectionBehaviour
    {
        //===============================================
        // SerializeField
        //===============================================
        [SerializeField] private bool m_withChildren = true;

        //===============================================
        // Field
        //===============================================
        private ParticleSystem m_particle = default;

        //===============================================
        // Method
        //===============================================

        private void Start()
        {
            m_particle = GetComponent<ParticleSystem>();
        }
        /// <summary>
        /// 
        /// </summary>
        protected override void ScaledTimeUpdate(ITimeScale time)
        {
            if (m_particle)
            {
                m_particle.Simulate(time.DeltaTime, m_withChildren);
            }
        }
    }
}