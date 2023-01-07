using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{

    [SerializeField]
    private GameObject obj_to_change;

    private void ChangeShardColour(Color col)
    {
        var shard_renderer = obj_to_change.GetComponent<Renderer>();
        if (shard_renderer != null) {
            shard_renderer.material.SetColor("_Color", col);
        }
    }
}
