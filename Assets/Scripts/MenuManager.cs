using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MenuManager : MonoBehaviour
{

    [SerializeField] Image imageToFade;
    // Start is called before the first frame update

    public static MenuManager instance;  // Create a instance for the Menu, similar to Player Instance.
    private void Start()
    {
        instance = this;
    }
    public void FadeImage()
    {
        imageToFade.GetComponent<Animator>().SetTrigger("Start Fading"); // Get Animator Component from the UI Image
    }
}

