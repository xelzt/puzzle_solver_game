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
    private void Start()
    {
        StartCoroutine(CheckIfCameraCollidesWithObject());
    }

    private IEnumerator CheckIfCameraCollidesWithObject()
    {
        while (true)
        {
            int hits = Physics.RaycastNonAlloc(Camera.transform.position, (Player.transform.position - Camera.transform.position).normalized, Hits, Vector3.Distance(Camera.transform.position, Player.transform.position), LayerMask);
            if (hits>0)
            {
                foreach(RaycastHit h in Hits)
                {
                    ObjectToHide objectToFade = GetFadingObjectFromHit(h);
                    if (objectToFade != null && !ObjectsBlockingView.Contains(objectToFade))
                    {
                        ObjectsBlockingView.Add(objectToFade);
                        StartCoroutine(FadeObjectOut(objectToFade));
                    }
                }
                
            }

            FadeObjectsNoLongerBeingHit();
            ResetHits();

            yield return null;
        }
    }

    private void FadeObjectsNoLongerBeingHit()
    {
        for (int i = 0; i < ObjectsBlockingView.Count; i++)
        {
            bool objectIsBeingHit = false;
            for (int j = 0; j < Hits.Length; j++)
            {
                ObjectToHide fadingObject = GetFadingObjectFromHit(Hits[j]);
                if (fadingObject != null && fadingObject == ObjectsBlockingView[i])
                {
                    objectIsBeingHit = true;
                    break;
                }

            }

            if(!objectIsBeingHit)
            {
                StopCoroutine(FadeObjectOut(ObjectsBlockingView[i]));
                StartCoroutine(FadeObjectIn(ObjectsBlockingView[i]));
                ObjectsBlockingView.RemoveAt(i);
            }
            

        }
    }
    private ObjectToHide GetFadingObjectFromHit(RaycastHit Hit)
    {
        return Hit.collider != null ? Hit.collider.GetComponent<ObjectToHide>() : null;
    } 

    private IEnumerator FadeObjectOut(ObjectToHide obj)
    {

        for (int i = 0; i < obj.Materials.Count; i++)
        {
            obj.Materials[i].SetInt("_SrcBlend", (int)UnityEngine.Rendering.BlendMode.SrcAlpha); // affects both "Transparent" and "Fade" options
            obj.Materials[i].SetInt("_DstBlend", (int)UnityEngine.Rendering.BlendMode.OneMinusSrcAlpha); // affects both "Transparent" and "Fade" options
            obj.Materials[i].SetInt("_ZWrite", 0); // disable Z writing
            obj.Materials[i].EnableKeyword("_ALPHABLEND_ON");
            obj.Materials[i].renderQueue = (int)UnityEngine.Rendering.RenderQueue.Transparent;
        }

        while (obj.Materials[0].color.a > 0.2f)
        {

            for (int i = 0; i < obj.Materials.Count; i++)
            {
                obj.Materials[i].color = new Color(
                    obj.Materials[i].color.r,
                    obj.Materials[i].color.g,
                    obj.Materials[i].color.b,
                    obj.Materials[0].color.a - (1f*Time.deltaTime)
                );
            }
            yield return null;
        }
    }

    private IEnumerator FadeObjectIn(ObjectToHide obj)
    {
        if (obj.Materials[0].HasProperty("_Color"))
        {
            while (obj.Materials[0].color.a < 1)
            {
                for (int i = 0; i < obj.Materials.Count; i++)
                {
                    if (obj.Materials[i].HasProperty("_Color"))
                    {
                        obj.Materials[i].color = new Color(
                            obj.Materials[i].color.r,
                            obj.Materials[i].color.g,
                            obj.Materials[i].color.b,
                            obj.Materials[0].color.a + (1f*Time.deltaTime)
                        );
                    }
                }

                yield return null;
            }
        }

        for (int i = 0; i < obj.Materials.Count; i++)
        {
            obj.Materials[i].DisableKeyword("_ALPHABLEND_ON");
            obj.Materials[i].DisableKeyword("_ALPHAPREMULTIPLY_ON");
            obj.Materials[i].SetInt("_SrcBlend", (int)UnityEngine.Rendering.BlendMode.One);
            obj.Materials[i].SetInt("_DstBlend", (int)UnityEngine.Rendering.BlendMode.Zero);
            obj.Materials[i].SetInt("_ZWrite", 1); // re-enable Z Writing
            obj.Materials[i].renderQueue = (int)UnityEngine.Rendering.RenderQueue.Geometry;
        }
    }

    private void ResetHits()
    {
        for(int i = 0; i < Hits.Length; i++)
        {
            Hits[i] = new RaycastHit();
        }
    }

}
