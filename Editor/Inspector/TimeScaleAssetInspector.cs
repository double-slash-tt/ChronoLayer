using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace ChronoLayer
{
    /// <summary>
    /// タイムアセットのインスペクタ
    /// </summary>
    [CustomEditor(typeof(TimeScaleAsset), true)]
    public class TimeAssetInspector : Editor
    {
        //===================================
        // Method
        //===================================
        public override void OnInspectorGUI()
        {
            if (target is TimeScaleAsset time)
            {
                using (var scope = new EditorGUI.ChangeCheckScope())
                {
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