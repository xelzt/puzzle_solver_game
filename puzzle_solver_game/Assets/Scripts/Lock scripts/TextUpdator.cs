    using UnityEngine;
    using UnityEngine.UI;

    public class TextUpdator : MonoBehaviour
    {
        Text text;
        int maxTries  = 1;
        public LockElex myObject;

        void Start()
        {
            text = GetComponent<Text>();
        }

        void Update()
        {
            if(myObject != null)
            {
                LockElex lockElex = GetComponent<LockElex>();
                text.text = "Max tries left: " + lockElex.maxTries;
            }
        }
    }