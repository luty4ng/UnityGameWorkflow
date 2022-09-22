using UnityEngine;
using UnityEngine.UI;
using System;
using System.Linq;
using System.Collections.Generic;
namespace UnityGameKit.Runtime
{

    public static partial class UnityExtension
    {
        #region GameObject
        public static void RemoveComponent<Component>(this GameObject obj, bool immediate = false)
        {
            Component component = obj.GetComponent<Component>();
            if (component != null)
            {
                if (immediate)
                {
                    UnityEngine.Object.DestroyImmediate(component as UnityEngine.Object, true);
                }
                else
                {
                    UnityEngine.Object.Destroy(component as UnityEngine.Object);
                }
            }
        }
        
        public static T GetGetComponentInAllParents<T>(this GameObject go) where T : MonoBehaviour
        {
            GameObject parent = go.transform.parent.gameObject;
            while (parent != null)
            {
                T output = parent.GetComponent<T>();
                if (output != null) return output;
            }
            return null;
        }
        #endregion

        #region Sprite
        public static void SetColor(this Image image, Color color)
        {
            Color tempColor = color;
            tempColor.a = image.color.a;
            image.color = tempColor;
        }

        public static void SetAlpha(this Image image, float alpha)
        {
            Color tempColor = image.color;
            tempColor.a = alpha;
            image.color = tempColor;
        }

        public static void SetAlpha(this SpriteRenderer spriteRenderer, float alpha)
        {
            Color tempColor = spriteRenderer.color;
            tempColor.a = alpha;
            spriteRenderer.color = tempColor;
        }
        #endregion

        #region Vector
        public static Vector2 ToVector2(this Vector3 vector3)
        {
            return new Vector2(vector3.x, vector3.z);
        }

        public static Vector3 ToVector3(this Vector2 vector2)
        {
            return new Vector3(vector2.x, 0f, vector2.y);
        }

        public static Vector3 ToVector3(this Vector2 vector2, float y)
        {
            return new Vector3(vector2.x, y, vector2.y);
        }

        public static Vector2 ToLocal(this Vector2 position, Transform transform)
        {
            return transform.InverseTransformPoint(position);
        }

        public static Vector3 ToLocal(this Vector3 position, Transform transform)
        {
            return transform.InverseTransformPoint(position);
        }

        public static Vector3 IgnoreX(this Vector3 position)
        {
            return new Vector3(0, position.y, position.z);
        }
        public static Vector3 IgnoreY(this Vector3 position)
        {
            return new Vector3(position.x, 0, position.z);
        }

        public static Vector3 IgnoreZ(this Vector3 position)
        {
            return new Vector3(position.x, position.y, 0);
        }

        public static float EuclidDistance(this Vector3 orgin, Vector3 end)
        {
            return (orgin - end).sqrMagnitude;
        }

        public static float EuclidDistance(this Vector2 orgin, Vector2 end)
        {
            return (orgin - end).sqrMagnitude;
        }

        public static Quaternion ToQuaternion(this Vector3 vector)
        {
            return Quaternion.Euler(vector);
        }

        public static Vector3 ToEuler(this Quaternion quaternion)
        {
            return quaternion.eulerAngles;
        }
        #endregion

        #region Transform
        public static void LocalRest(this Transform tr)
        {
            tr.localPosition = Vector3.zero;
            tr.localRotation = Quaternion.identity;
            tr.localScale = Vector3.one;
        }
        public static void Reset(this Transform tr)
        {
            tr.position = Vector3.zero;
            tr.rotation = Quaternion.identity;
            tr.localScale = Vector3.zero;
        }
        public static Transform FindParent(this Transform tr, string name)
        {
            Transform parent = tr.parent;
            while (parent != null && parent.name != name)
                parent = parent.parent;
            return parent;
        }

        public static string GetPathName(this Transform trans, Transform endParent)
        {
            Transform parent = trans.parent;
            string pathName = trans.gameObject.name;
            while (parent != null && parent != endParent)
            {
                pathName = pathName.Insert(0, parent.gameObject.name + "/");
                parent = parent.parent;
            }
            return pathName;
        }

        public static void SetPositionX(this Transform transform, float newValue)
        {
            Vector3 v = transform.position;
            v.x = newValue;
            transform.position = v;
        }

        public static void SetPositionY(this Transform transform, float newValue)
        {
            Vector3 v = transform.position;
            v.y = newValue;
            transform.position = v;
        }

        public static void SetPositionZ(this Transform transform, float newValue)
        {
            Vector3 v = transform.position;
            v.z = newValue;
            transform.position = v;
        }

        public static void AddPositionX(this Transform transform, float deltaValue)
        {
            Vector3 v = transform.position;
            v.x += deltaValue;
            transform.position = v;
        }

        public static void AddPositionY(this Transform transform, float deltaValue)
        {
            Vector3 v = transform.position;
            v.y += deltaValue;
            transform.position = v;
        }

        public static void AddPositionZ(this Transform transform, float deltaValue)
        {
            Vector3 v = transform.position;
            v.z += deltaValue;
            transform.position = v;
        }

        public static void SetLocalPositionX(this Transform transform, float newValue)
        {
            Vector3 v = transform.localPosition;
            v.x = newValue;
            transform.localPosition = v;
        }

        public static void SetLocalPositionY(this Transform transform, float newValue)
        {
            Vector3 v = transform.localPosition;
            v.y = newValue;
            transform.localPosition = v;
        }

        public static void SetLocalPositionZ(this Transform transform, float newValue)
        {
            Vector3 v = transform.localPosition;
            v.z = newValue;
            transform.localPosition = v;
        }

        public static void AddLocalPositionX(this Transform transform, float deltaValue)
        {
            Vector3 v = transform.localPosition;
            v.x += deltaValue;
            transform.localPosition = v;
        }

        public static void AddLocalPositionY(this Transform transform, float deltaValue)
        {
            Vector3 v = transform.localPosition;
            v.y += deltaValue;
            transform.localPosition = v;
        }

        public static void AddLocalPositionZ(this Transform transform, float deltaValue)
        {
            Vector3 v = transform.localPosition;
            v.z += deltaValue;
            transform.localPosition = v;
        }

        public static void SetLocalScaleX(this Transform transform, float newValue)
        {
            Vector3 v = transform.localScale;
            v.x = newValue;
            transform.localScale = v;
        }

        public static void SetLocalScaleY(this Transform transform, float newValue)
        {
            Vector3 v = transform.localScale;
            v.y = newValue;
            transform.localScale = v;
        }

        public static void SetLocalScaleZ(this Transform transform, float newValue)
        {
            Vector3 v = transform.localScale;
            v.z = newValue;
            transform.localScale = v;
        }

        public static void AddLocalScaleX(this Transform transform, float deltaValue)
        {
            Vector3 v = transform.localScale;
            v.x += deltaValue;
            transform.localScale = v;
        }

        public static void AddLocalScaleY(this Transform transform, float deltaValue)
        {
            Vector3 v = transform.localScale;
            v.y += deltaValue;
            transform.localScale = v;
        }

        public static void AddLocalScaleZ(this Transform transform, float deltaValue)
        {
            Vector3 v = transform.localScale;
            v.z += deltaValue;
            transform.localScale = v;
        }

        public static void LookAt2D(this Transform transform, Vector2 lookAtPoint2D)
        {
            Vector3 vector = lookAtPoint2D.ToVector3() - transform.position;
            vector.y = 0f;

            if (vector.magnitude > 0f)
            {
                transform.rotation = Quaternion.LookRotation(vector.normalized, Vector3.up);
            }
        }

        #endregion Transform
    }
}
