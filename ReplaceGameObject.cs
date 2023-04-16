using UnityEngine;
using UnityEngine.UI;

public class ReplaceGameObject : MonoBehaviour
{
    public GameObject originalObject;
    public GameObject replacementObject;
    public Button replaceButton;

    void Start()
    {
        replaceButton.onClick.AddListener(ReplaceObject);
    }

    void ReplaceObject()
    {
        originalObject.SetActive(false);
        replacementObject.SetActive(true);
    }
}
