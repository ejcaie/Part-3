using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DamageDisplay : MonoBehaviour
{
    public static TextMeshProUGUI dmgDisplay;
    private void Start()
    {
        dmgDisplay = GetComponent<TextMeshProUGUI>();
    }
    public static void Update()
    {
        dmgDisplay.text = PlayerControls.hits.ToString();
    }
}
