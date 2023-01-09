using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{

    [SerializeField]
    private GameObject shard;

    private void ChangeShardColour(Color col)
    {
        var shard_renderer = shard.GetComponent<Renderer>();
        if (shard_renderer != null) {
            shard_renderer.material.SetColor("_Color", col);
        }
    }
}
