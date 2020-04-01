using UnityEngine;

[RequireComponent(typeof(Animator))]
public class AnimatorBehaviour : MonoBehaviour
{
    private Animator animatorObj;
    public int intValue = 1;
    public float floatValue = 1f;
    void Start()
    {
        animatorObj = GetComponent<Animator>();
    }

    public void SetInt (string parameterName)
    {
        animatorObj.SetInteger(parameterName, intValue);
    }
    
    public void SetFloat (string parameterName)
    {
        animatorObj.SetFloat(parameterName, floatValue);
    }

    public void ChangeBoolParameterTrue (string parameterName)
    {
        animatorObj.SetBool(parameterName, true);
    }
    
    public void ChangeBoolParameterFalse (string parameterName)
    {
        animatorObj.SetBool(parameterName, false);
    }
}