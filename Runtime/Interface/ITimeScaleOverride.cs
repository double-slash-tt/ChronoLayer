using UnityEditor;
using UnityEngine;

namespace ChronoLayer
{
    /// <summary>
    /// 書き込み可能
    /// </summary>
    public interface ITimeScaleOverride
    {
        float LocalScale { get; set; }
    }
}