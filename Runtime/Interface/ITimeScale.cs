using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ChronoLayer
{
    /// <summary>
    /// �^�C���X�P�[����������
    /// </summary>
    public interface ITimeScale
    {
        float TimeScale { get; }
        float DeltaTime { get; }
    }
 
}