using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideObjectsBetweenCameraAndPlayer : MonoBehaviour
{
    [SerializeField]
    private LayerMask LayerMask;
    [SerializeField]
    private Camera Camera;
    [SerializeField]
    private Transform Player;
    private List<ObjectToHide> ObjectsBlockingView = new List<ObjectToHide>();
    private RaycastHit[] Hits = new RaycastHit[10];
    private Dictionary<ObjectToHide, Coroutine> ViewBlockingObjectsCoroutines = new Dictionary<ObjectToHide, Coroutine>(); 

    private void Update()
    {
        int hits = Physics.RaycastNonAlloc(Camera.transform.position, (Player.transform.position - Camera.transform.position).normalized, Hits, Vector3.Distance(Camera.transform.position, Player.transform.position), LayerMask);
        if (hits > 0)
        {
            foreach (RaycastHit hit in Hits)
            {
                ObjectToHide ViewBlockingObject = GetViewBlockingObjectsFromHit(hit);
                if (ViewBlockingObject != null && !ObjectsBlockingView.Contains(ViewBlockingObject))
                {
                    ResetCoroutines(ViewBlockingObject);
                    ViewBlockingObjectsCoroutines.Add(ViewBlockingObject, StartCoroutine(FadeBlockingObject(ViewBlockingObject)));
                    ObjectsBlockingView.Add(ViewBlockingObject);
                }
            }
        }
        ResetObjectsWhichAreNotHit();
        ResetHits();
    }

    private ObjectToHide GetViewBlockingObjectsFromHit(RaycastHit Hit)
    {
        return Hit.collider != null ? Hit.collider.GetComponent<ObjectToHide>() : null;
    }

    private void ResetCoroutines(ObjectToHide ViewBlockingObject)
    {
        if (ViewBlockingObjectsCoroutines.ContainsKey(ViewBlockingObject))
        {
            if (ViewBlockingObjectsCoroutines[ViewBlockingObject] != null)
            {
                StopCoroutine(ViewBlockingObjectsCoroutines[ViewBlockingObject]);
            }
            ViewBlockingObjectsCoroutines.Remove(ViewBlockingObject);
        }
    }

    private IEnumerator FadeBlockingObject(ObjectToHide obj)
    {

        obj.Materials.ForEach(m => { ModifyShaderMaterialForFade(m); });

        while (obj.Materials[0].color.a > 0.2f)
        {
            obj.Materials.ForEach(m => { m.color = new Color(m.color.r, m.color.g, m.color.b, m.color.a - (1f * Time.deltaTime)); });
            yield return null;
        }
    }

    private void ModifyShaderMaterialForFade(Material mat)
    {
        mat.SetInt("_SrcBlend", (int)UnityEngine.Rendering.BlendMode.SrcAlpha);
        mat.SetInt("_DstBlend", (int)UnityEngine.Rendering.BlendMode.OneMinusSrcAlpha);
        mat.SetInt("_ZWrite", 0);
        mat.EnableKeyword("_ALPHABLEND_ON");
        mat.renderQueue = (int)UnityEngine.Rendering.RenderQueue.Transparent;
    }

    private void ResetObjectsWhichAreNotHit()
    {
        for (int i = 0; i < ObjectsBlockingView.Count; i++)
        {
            bool IsObjectHit = false;

            foreach(RaycastHit hit in Hits)
            {
                ObjectToHide ViewBlockingObject = GetViewBlockingObjectsFromHit(hit);
                if (ViewBlockingObject != null && ViewBlockingObject == ObjectsBlockingView[i])
                {
                    IsObjectHit = true;
                }
            }

            if(!IsObjectHit)
            {
                ResetCoroutines(ObjectsBlockingView[i]);
                ViewBlockingObjectsCoroutines.Add(ObjectsBlockingView[i], StartCoroutine(ResetObjectFade(ObjectsBlockingView[i])));
                ObjectsBlockingView.RemoveAt(i);
            }
        }
    }

    private IEnumerator ResetObjectFade(ObjectToHide obj)
    {

        while (obj.Materials[0].color.a < 1)
        {
            obj.Materials.ForEach(m => { m.color = new Color(m.color.r, m.color.g, m.color.b, m.color.a + (1f * Time.deltaTime)); });
            yield return null;
        }
        obj.Materials.ForEach(m => { ResetShaderMaterial(m); });
    }

    private void ResetShaderMaterial(Material mat)
    {
        mat.DisableKeyword("_ALPHABLEND_ON");
        mat.DisableKeyword("_ALPHAPREMULTIPLY_ON");
        mat.SetInt("_SrcBlend", (int)UnityEngine.Rendering.BlendMode.One);
        mat.SetInt("_DstBlend", (int)UnityEngine.Rendering.BlendMode.Zero);
        mat.SetInt("_ZWrite", 1);
        mat.renderQueue = (int)UnityEngine.Rendering.RenderQueue.Geometry;
    }

    private void ResetHits()
    {
        for(int i = 0; i < Hits.Length; i++)
        {
            Hits[i] = new RaycastHit();
        }
    }

}
