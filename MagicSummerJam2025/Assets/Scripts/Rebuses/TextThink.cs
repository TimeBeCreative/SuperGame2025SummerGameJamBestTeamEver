using UnityEngine;
using System.Collections.Generic;
using TMPro;


public class TextThink : MonoBehaviour
{
    private Dictionary<string, string> correcAnswers = new Dictionary<string, string>()
    {
        { "Field1", "TimeBeCreative"}
    };

   public void CheckAnswer()
    {
        string key = this.name;
        string input = GetComponent<TMP_InputField>().text;

        if (!string.IsNullOrEmpty(input))
        {
            if (correcAnswers.ContainsKey(key))
            {
                if (input.Equals(correcAnswers[key], System.StringComparison.OrdinalIgnoreCase))
                {
                    Debug.Log("1 Correct");
                }
                else
                {
                    Debug.Log("Incorrect");
                }
            }
        }
    }
  
}

