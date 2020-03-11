using UnityEngine;
using UnityEngine.UI;

namespace UnityScriptingFoundation.Scripts.Behaviours
{
    [RequireComponent(typeof(Text))]
    public class TextBehaviour : MonoBehaviour
    {
        private Text textObj;
        public IntData dataObj;

        void Start()
        {
            textObj = GetComponent<Text>();
        }


        void Update()
        {
            textObj.text = dataObj.value.ToString();
        }
    }
}
