using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayCost : MonoBehaviour
{
    // Cache
    [SerializeField] Defender defenderPrefab;
    Text defenderText;
    int defenderStarCost;
    
    // Start is called before the first frame update
    void Start()
    {
        defenderText = GetComponent<Text>();
        defenderStarCost = defenderPrefab.ReportStarCost();
        defenderText.text = defenderStarCost.ToString();
    }
}
