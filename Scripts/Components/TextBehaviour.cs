using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class TextBehaviour : MonoBehaviour
{
    private Text textObj;

    void Start()
    {
        textObj = GetComponent<Text>();
        print(textObj);
    }

    public void ChangeText(string message)
    {
        
        print(message);
        textObj.text = message;
    }

    public void ChangeText(IntData obj)
    {
        textObj.text = obj.value.ToString();
    }
}