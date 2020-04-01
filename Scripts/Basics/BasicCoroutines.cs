
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class BasicCoroutines : MonoBehaviour
{
    public int counter = 3;
    public float seconds = 1f;
    public IntData numberData;
    public UnityEvent startEvent, repeatEvent, endEvent, postEndEvent;
    private WaitForSeconds waitObj;
    
    private IEnumerator Start()
    {
        waitObj = new WaitForSeconds(seconds);
        startEvent.Invoke();
        while (counter > 0)
        {
            numberData.value = counter;
            yield return waitObj;
            repeatEvent.Invoke();
            counter--;
        }
        yield return waitObj;
        endEvent.Invoke();
        yield return waitObj;
        postEndEvent.Invoke();
    }
}