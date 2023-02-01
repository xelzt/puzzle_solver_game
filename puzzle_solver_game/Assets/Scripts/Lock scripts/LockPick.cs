﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockPick : MonoBehaviour
{
    [SerializeField]
    GameObject canvasPanel;
    public Camera cam;
    public Transform innerLock;
    public Transform pickPosition;
    private readonly float maxAngle = 90;
    private readonly float lockSpeed = 10;
    private readonly float lockRange = 10;
    private float eulerAngle;
    private float unlockAngle;
    private Vector2 unlockRange;

    private float keyPressTime = 0;
    private bool movePick;

    void Start()
    {
        NewLock();
    }
    void Update()
    {
        if (HasPick())
        {
            CheckResult();
        }
        Escape();
    }
    private void Escape()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            canvasPanel.SetActive(false);
        }
    }
    private bool HasPick()
    {
        foreach  (var invItem in InventoryManager.Instance.itemList)
        {
            if (invItem.itemName == "Wytrych")
            {
                movePick = true;
            }
            else movePick = false;
        }
        return movePick;
    }
    private void CheckResult()
    {
        transform.localPosition = pickPosition.position;
        if (movePick)
        {
            Vector3 dir = Input.mousePosition - cam.WorldToScreenPoint(transform.position);

            eulerAngle = Vector3.Angle(dir, Vector3.up);

            Vector3 cross = Vector3.Cross(Vector3.up, dir);
            if (cross.z < 0) { eulerAngle = -eulerAngle; }

            eulerAngle = Mathf.Clamp(eulerAngle, -maxAngle, maxAngle);

            Quaternion rotateTo = Quaternion.AngleAxis(eulerAngle, Vector3.forward);
            transform.rotation = rotateTo;
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            movePick = false;
            keyPressTime = 1;
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            movePick = true;
            keyPressTime = 0;
        }

        float percentage = Mathf.Round(100 - Mathf.Abs(((eulerAngle - unlockAngle) / 100) * 100));
        float lockRotation = ((percentage / 100) * maxAngle) * keyPressTime;
        float maxRotation = (percentage / 100) * maxAngle;

        float lockLerp = Mathf.LerpAngle(innerLock.eulerAngles.z, lockRotation, Time.deltaTime * lockSpeed);
        innerLock.eulerAngles = new Vector3(0, 0, lockLerp);
        if (lockLerp >= maxRotation - 1)
        {
            if (eulerAngle < unlockRange.y && eulerAngle > unlockRange.x)
            {
                PlayerPrefs.SetInt("DidLockPickQuest", 1);
                PlayerPrefs.Save();
                canvasPanel.SetActive(false);
            }
            else
            {
                float randomRotation = Random.insideUnitCircle.x;
                transform.eulerAngles += new Vector3(0, 0, Random.Range(-randomRotation, randomRotation));
            }
        }
    }
    void NewLock()
    {
        unlockAngle = Random.Range(-maxAngle + lockRange, maxAngle - lockRange);
        unlockRange = new Vector2(unlockAngle - lockRange, unlockAngle + lockRange);
    }
}
