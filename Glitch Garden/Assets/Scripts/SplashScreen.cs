using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreen : MonoBehaviour
{
    // Declare variables
    [SerializeField] float loadingDelay = 5f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoadGameAfterDelay());
    }

    IEnumerator LoadGameAfterDelay()
    {
        yield return new WaitForSeconds(loadingDelay);
        SceneManager.LoadScene("Menu");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
