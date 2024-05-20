using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class HUDController : MonoBehaviour
{
    public static HUDController instance;

    [SerializeField] TMP_Text interacgtionText;
    private void Awake()
    {
        instance = this; 
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EnableInteractionText(string text)
    {
        interacgtionText.text = text + " (F)";
        interacgtionText.gameObject.SetActive(true);
    }

    public void DisableInteractionText()
    {
        interacgtionText.gameObject.SetActive(false);
    }
}
