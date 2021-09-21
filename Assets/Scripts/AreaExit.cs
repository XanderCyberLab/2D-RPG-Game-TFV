using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AreaExit : MonoBehaviour
{
    [SerializeField] string loadingScene;
    [SerializeField] string transitonAreaName;
    [SerializeField] AreaEnter theAreaEnter;
    // Start is called before the first frame update
    void Start()
    {
        theAreaEnter.transitionAreaName = transitonAreaName;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) // Make sure a player has entered
        {
            Player.instance.transitionName = transitonAreaName; // Set the transition position to start
            MenuManager.instance.FadeImage(); // Fade in Image
            StartCoroutine(LoadSceneCoroutine()); // Start Coroutine
     
        }
    }
    // Coroutine: Method to suspend execution of instruction until certain conditions are met.. Known as Yield

    IEnumerator LoadSceneCoroutine()
    {
        yield return new WaitForSeconds(1f); // Adds a second to load scene
        SceneManager.LoadScene(loadingScene);
    }
}
