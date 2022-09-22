using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using GameKit;

public class MonoManager : SingletonBase<MonoManager>
{
    public GameMonoCenter controller;
    public Dictionary<string, GameObject> globalObjects;
    public MonoManager()
    {
        GameObject obj = new GameObject("GameMonoCenter");
        controller = obj.AddComponent<GameMonoCenter>();
    }

    public void AddUpdateListener(UnityAction func)
    {
        controller.AddUpdateListener(func);
    }

    public void RemoveUpdateListener(UnityAction func)
    {
        controller.RemoveUpdateListener(func);
    }

    public Coroutine StartCoroutine(IEnumerator routine)
    {
        return controller.StartCoroutine(routine);
    }

    public void StopCorroutie(Coroutine routine)
    {
        controller.StopCoroutine(routine);
    }

    public Coroutine StartCoroutine(string methodName)
    {
        return controller.StartCoroutine(methodName);
    }

    public void TryGetMonoObject(string name, out GameObject Object)
    {
        if (!globalObjects.ContainsKey(name))
        {
            GameObject obj = GameObject.Find(name);
            globalObjects.Add(name, obj);
        }
        Object = globalObjects[name];
    }
}
