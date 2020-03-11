using UnityEngine;

namespace UnityScriptingFoundation.Scripts.Behaviours
{
   [CreateAssetMenu]
   public class IntData : ScriptableObject
   {
      public int value = 1;

      public void ChangeValue(int number)
      {
         value += number;
      }
   }
}