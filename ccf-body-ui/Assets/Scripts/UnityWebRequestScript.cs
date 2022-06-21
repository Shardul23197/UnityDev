using System.Collections;
using UnityEngine.Networking;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class UnityWebRequestScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(getRequest("https://ccf-api.hubmapconsortium.org/v1/scene"));
    }

    //Read from url and store in file
    IEnumerator getRequest(string uri)
    {
        UnityWebRequest uwr = UnityWebRequest.Get(uri);
        yield return uwr.SendWebRequest();
        
        
        Debug.Log("Received: " + uwr.downloadHandler.text);

        File.WriteAllText(Application.dataPath + "/response1.txt", uwr.downloadHandler.text);
    }
}
