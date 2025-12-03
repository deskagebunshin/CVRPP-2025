using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public float timeBeforeEndOfScene = 5;
    public float transitionTime = 1;
    public string nextScene;
    public MeshRenderer fader;
    void Start()
    {
        StartCoroutine(Timer());
        fader.material.SetFloat("_Fade", 1);
    }


    IEnumerator Timer()
    {
        float t = 0;

        while (t < transitionTime)
        {
            yield return new WaitForEndOfFrame();
            t += Time.deltaTime;
            fader.material.SetFloat("_Fade", 1 - (t/transitionTime));

        }

        yield return new WaitForSeconds(timeBeforeEndOfScene);

        t = 0;

        while (t < transitionTime)
        {
            yield return new WaitForEndOfFrame();
            t += Time.deltaTime;
            fader.material.SetFloat("_Fade", t/transitionTime);
        }

        SceneManager.LoadScene(nextScene);

    }
}
