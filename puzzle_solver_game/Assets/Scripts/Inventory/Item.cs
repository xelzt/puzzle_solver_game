using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    public enum ItemType
    {
        PassCodeHint,
        SkeletonKey,
    }

    public ItemType ItemTypes;
    public int amount;
}
