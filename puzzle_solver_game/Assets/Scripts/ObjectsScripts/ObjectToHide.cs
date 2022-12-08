using System;
using System.Collections.Generic;
using UnityEngine;

public class ObjectToHide : MonoBehaviour, IEquatable<ObjectToHide>
{
    
    public List<Renderer> Renderers = new List<Renderer>();
    public List<Material> Materials = new List<Material>();
    public Vector3 Position;
    public float Alpha;

    public void Awake()
    {
        Position = transform.position;
        GetAllObjectRenderers();
        GetAllObjectMaterials();
        Alpha = Materials[0].color.a;
    }

    private void GetAllObjectRenderers()
    {
        if(Renderers.Count == 0)
        {
            Renderers.AddRange(GetComponentsInChildren<Renderer>());
        }
    }

    private void GetAllObjectMaterials()
    {
        foreach(Renderer r in Renderers)
        {
            Materials.AddRange(r.materials);
        }
    }

    public bool Equals(ObjectToHide obj)
    {
        return Position.Equals(obj.Position);
    }
    
    // override object.GetHashCode
    public override int GetHashCode()
    {
        return Position.GetHashCode();
    }
}
