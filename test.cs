using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
 
public class LoadAssetBundlesRemote2 : MonoBehaviour
{
    public string assetName;
 
    void Start()
    {
        StartCoroutine(DownloadAsset());
    }
 
    IEnumerator DownloadAsset()
    {
        using (UnityWebRequest uwr = UnityWebRequestAssetBundle.GetAssetBundle(" The correct private google drive url"))
     
        {
            yield return uwr.SendWebRequest();
 
            if (uwr.isNetworkError || uwr.isHttpError)
            {
                Debug.Log(uwr.error);
            }
            else
            {
                // Get downloaded asset bundle
                AssetBundle bundle = DownloadHandlerAssetBundle.GetContent(uwr);
                var prefab = bundle.LoadAsset(assetName);
                Instantiate(prefab);
            }
        }
    }
}