using UnityEngine;

[RequireComponent(typeof(Animator))]
public class AnimatorBehaviour : MonoBehaviour
{
    private Animator animatorObj;
    public int intValue = 1;
    public float floatValue = 1f;

    private void Awake()
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

    public void SetBoolParameterTrue (string parameterName)
    {
        animatorObj.SetBool(parameterName, true);
    }
    
    public void SetBoolParameterFalse (string parameterName)
    {
        animatorObj.SetBool(parameterName, false);
    }
}