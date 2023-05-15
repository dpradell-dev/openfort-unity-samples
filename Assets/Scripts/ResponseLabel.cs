using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ResponseLabel : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI label;

    public void SetText(string value)
    {
        label.text = value;
    }
}
