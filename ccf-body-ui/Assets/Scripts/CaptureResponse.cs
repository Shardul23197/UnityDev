using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaptureResponse : MonoBehaviour
{
    public TextAsset textJSON;

    [System.Serializable]

    public class ResponseObject
    {
        public string @id;
        public string @type;
        public string representation_of;
        public string reference_organ;
        public string scenegraph;
        public string scenegraphNode;
        public int[] transformMatrix;
        public string tooltip;
        public int[] color;
        public int opacity;
        public bool unpickable;
        public string _lighting;
        public bool zoomBasedOpacity;
    }

    [System.Serializable]

    public class ResponseObjectList
    {
        public ResponseObject[] responseObject;
    }

    public ResponseObjectList myResponseObjectList = new ResponseObjectList();
    // Start is called before the first frame update
    void Start()
    {
        myResponseObjectList = JsonUtility.FromJson<ResponseObjectList>(textJSON.text); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
