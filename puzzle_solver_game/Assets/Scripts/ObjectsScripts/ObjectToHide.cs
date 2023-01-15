using System;
using System.Collections.Generic;
using UnityEngine;

public class ObjectToHide : MonoBehaviour, IEquatable<ObjectToHide>
{
    
    public List<Renderer> Renderers = new List<Renderer>();
    public List<Material> Materials = new List<Material>();
    public float Alpha;

    public void Awake()
    {
        GetAllObjectMaterials();
    }

    private void GetAllObjectMaterials()
    {
        Renderer[] renderers = GetComponentsInChildren<Renderer>();
        foreach (Renderer r in renderers)
        {
            Materials.AddRange(r.materials);
        }
    }

    public bool Equals(ObjectToHide obj)
    {
        return transform.position.Equals(obj.transform.position);
    }
    
    // override object.GetHashCode
    public override int GetHashCode()
    {
        return transform.position.GetHashCode();
    }
}
