using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace ChronoLayer.Impl
{
    /// <summary>
    /// タイムアセットのインスペクタ
    /// </summary>
    [CustomEditor(typeof(ChildTimeScaleAsset), true)]
    public sealed class ChildTimeAssetInspector : Editor
    {
        //===================================
        // Method
        //===================================
        public override void OnInspectorGUI()
        {
            if (target is ChildTimeScaleAsset time)
            {
                using (var scope = new EditorGUI.ChangeCheckScope())
                {
                    time.InitialScale = EditorGUILayout.Slider(
                        label: nameof(time.InitialScale),
                        value: time.InitialScale,
                        leftValue: 0,
                        rightValue: 10
                    );

                    time.LocalScale = EditorGUILayout.Slider(
                        label: nameof(time.LocalScale),
                        value: time.LocalScale,
                        leftValue: 0,
                        rightValue: 10
                    );

                    EditorGUILayout.LabelField(nameof(time.DeltaTime), time.DeltaTime.ToString());
                    EditorGUILayout.LabelField(nameof(time.TimeScale), time.TimeScale.ToString());

                    if (scope.changed)
                    {
                        EditorUtility.SetDirty(time);
                    }
                }
            }
        }
    }
}