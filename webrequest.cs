using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using TMPro; 

public class Testing : MonoBehaviour {
    private void Start() {
        string url = "http://google.com";
        StartCoroutine(Get(url));
    }

    private IEnumerator Get(string url) {
        using (UnityWebRequest unityWebRequest = UnityWebRequest.Get(url)) {
            yield return unityWebRequest.SendWebRequest();

            if (unityWebRequest.isNetworkError || unityWebRequest.isHttpError) {
                Debug.Log("Error: " + unityWebRequest.error);
            } else {
                Debug.Log("Received: " + unityWebRequest.downloadHandler.text);
            }
        }
    }
}