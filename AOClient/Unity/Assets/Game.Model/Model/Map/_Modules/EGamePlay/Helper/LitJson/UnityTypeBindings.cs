﻿using UnityEngine;
using System;
using System.Collections;

using LitJson.Extensions;
using Unity.Mathematics;

namespace LitJson
{

#if UNITY_EDITOR
    [UnityEditor.InitializeOnLoad]
#endif
#if UNITY
    /// <summary>
    /// Unity内建类型拓展
    /// </summary>
    public static class UnityTypeBindings
    {

        static bool registerd;

        static UnityTypeBindings()
        {
            Register();
        }

        public static void Register()
        {

            if (registerd) return;
            registerd = true;


            // 注册Type类型的Exporter
            JsonMapper.RegisterExporter<Type>((v, w) =>
            {
                w.Write(v.FullName);
            });

            JsonMapper.RegisterImporter<string, Type>((s) =>
            {
                return Type.GetType(s);
            });

            // 注册Vector2类型的Exporter
            Action<Vector2, JsonWriter> writeVector2 = (v, w) =>
            {
                w.WriteObjectStart();
                w.WriteProperty("x", v.x);
                w.WriteProperty("y", v.y);
                w.WriteObjectEnd();
            };

            JsonMapper.RegisterExporter<Vector2>((v, w) =>
            {
                writeVector2(v, w);
            });

            // 注册Vector3类型的Exporter
            Action<Vector3, JsonWriter> writeVector3 = (v, w) =>
            {
                w.WriteObjectStart();
                w.WriteProperty("x", v.x);
                w.WriteProperty("y", v.y);
                w.WriteProperty("z", v.z);
                w.WriteObjectEnd();
            };

            JsonMapper.RegisterExporter<Vector3>((v, w) =>
            {
                writeVector3(v, w);
            });

            // 注册Vector3类型的Exporter
            Action<float3, JsonWriter> writefloat3 = (v, w) =>
            {
                w.WriteObjectStart();
                w.WriteProperty("x", v.x);
                w.WriteProperty("y", v.y);
                w.WriteProperty("z", v.z);
                w.WriteObjectEnd();
            };

            JsonMapper.RegisterExporter<float3>((v, w) =>
            {
                writefloat3(v, w);
            });

            // 注册Vector4类型的Exporter
            JsonMapper.RegisterExporter<Vector4>((v, w) =>
            {
                w.WriteObjectStart();
                w.WriteProperty("x", v.x);
                w.WriteProperty("y", v.y);
                w.WriteProperty("z", v.z);
                w.WriteProperty("w", v.w);
                w.WriteObjectEnd();
            });

            // 注册Quaternion类型的Exporter
            JsonMapper.RegisterExporter<Quaternion>((v, w) =>
            {
                w.WriteObjectStart();
                w.WriteProperty("x", v.x);
                w.WriteProperty("y", v.y);
                w.WriteProperty("z", v.z);
                w.WriteProperty("w", v.w);
                w.WriteObjectEnd();
            });

            // 注册Color类型的Exporter
            JsonMapper.RegisterExporter<Color>((v, w) =>
            {
                w.WriteObjectStart();
                w.WriteProperty("r", v.r);
                w.WriteProperty("g", v.g);
                w.WriteProperty("b", v.b);
                w.WriteProperty("a", v.a);
                w.WriteObjectEnd();
            });

            // 注册Color32类型的Exporter
            JsonMapper.RegisterExporter<Color32>((v, w) =>
            {
                w.WriteObjectStart();
                w.WriteProperty("r", v.r);
                w.WriteProperty("g", v.g);
                w.WriteProperty("b", v.b);
                w.WriteProperty("a", v.a);
                w.WriteObjectEnd();
            });

            // 注册Bounds类型的Exporter
            JsonMapper.RegisterExporter<Bounds>((v, w) =>
            {
                w.WriteObjectStart();

                w.WritePropertyName("center");
                writeVector3(v.center, w);

                w.WritePropertyName("size");
                writeVector3(v.size, w);

                w.WriteObjectEnd();
            });

            // 注册Rect类型的Exporter
            JsonMapper.RegisterExporter<Rect>((v, w) =>
            {
                w.WriteObjectStart();
                w.WriteProperty("x", v.x);
                w.WriteProperty("y", v.y);
                w.WriteProperty("width", v.width);
                w.WriteProperty("height", v.height);
                w.WriteObjectEnd();
            });

            // 注册RectOffset类型的Exporter
            JsonMapper.RegisterExporter<RectOffset>((v, w) =>
            {
                w.WriteObjectStart();
                w.WriteProperty("top", v.top);
                w.WriteProperty("left", v.left);
                w.WriteProperty("bottom", v.bottom);
                w.WriteProperty("right", v.right);
                w.WriteObjectEnd();
            });

        }

    }
#endif
}
