using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ResourceManager : MonoBehaviour
{
    // Variables
    int StarBallance = 1000;

    // Cache
    Text StarBalText;

    // Start is called at start
    private void Start()
    {
        StarBalText = GetComponent<Text>();
        UpdateStarBal();
    }

    // Debits StarBalance
    public void DebitStarBal(int Debit)
    {
        StarBallance -= Debit;
        UpdateStarBal();
    }

    // Credts StarBalance
    public void CreditStarBal(int Credit)
    {
        StarBallance += Credit;
        UpdateStarBal();
    }

    // Updates Star Balance text
    private void UpdateStarBal()
    {
        StarBalText.text = StarBallance.ToString();
    }
}
