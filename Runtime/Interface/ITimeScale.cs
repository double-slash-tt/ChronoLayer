using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ChronoLayer
{
    /// <summary>
    /// タイムスケール情報を持つ
    /// </summary>
    public interface ITimeScale
    {
        float TimeScale { get; }
        float DeltaTime { get; }
    }
 
}