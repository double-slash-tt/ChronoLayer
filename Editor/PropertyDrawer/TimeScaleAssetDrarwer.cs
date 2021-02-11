using UnityEditor;
using UnityEngine;

namespace ChronoLayer
{
    /// <summary>
    /// TimeScaleアセットのプロパティ
    /// </summary>
    [CustomPropertyDrawer(typeof(TimeScaleAsset), true)]
    public sealed class TimeScaleAssetDrarwer : PropertyDrawer
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="position"></param>
        /// <param name="property"></param>
        /// <param name="label"></param>
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            if (property.objectReferenceValue is TimeScaleAsset time)
            {
                var left = new Rect(position);
                left.width = position.width * 0.3f;
                var right = new Rect(position);
                right.xMin = position.center.x;
                right.width = position.width * 0.5f;
                using (var scope = new EditorGUI.ChangeCheckScope())
                {

                    property.objectReferenceValue = EditorGUI.ObjectField(left, time, typeof(TimeScaleAsset), false);
                    time.LocalScale = EditorGUI.Slider(right, time.LocalScale, 0, 10);
                    if (scope.changed)
                    {
                        EditorUtility.SetDirty(time);
                    }
                }
            }
        }
    }
}