using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScreenAnimation : MonoBehaviour
{
    public CanvasGroup canvasgroup;
    public void StartFade()
    {
        StartCoroutine(FadeInOutRoutine());
    }

    private IEnumerator FadeInOutRoutine()
    {

        float duration = 0.5f;
        float time = 0;

        yield return new WaitForSeconds(0.25f);

        //Fade in
        while (time < duration)
        {
            time = time + Time.deltaTime;
            float distance = time / duration;
            canvasgroup.alpha = distance;
            yield return new WaitForEndOfFrame();
        }


        yield return new WaitForSeconds(1);

        //fade out 
        while (time > 0)
        {
            time = time - Time.deltaTime;
            float distance = time / duration;
            canvasgroup.alpha = distance;
            yield return new WaitForEndOfFrame();
        }

        yield return new WaitForSeconds(1);

        //reset
        SceneManager.LoadScene("SampleScene");
    }
}
