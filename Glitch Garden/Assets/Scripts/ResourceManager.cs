using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ResourceManager : MonoBehaviour
{
    // Variables
    int starBallance = 1000;

    // Cache
    Text starBalText;

    // Start is called at start
    private void Start()
    {
        starBalText = GetComponent<Text>();
        UpdateStarBal();
    }

    // Debits StarBalance
    public void DebitStarBal(int Debit)
    {
        starBallance -= Debit;
        UpdateStarBal();
    }

    // Credts StarBalance
    public void CreditStarBal(int Credit)
    {
        starBallance += Credit;
        UpdateStarBal();
    }

    // Updates Star Balance text
    private void UpdateStarBal()
    {
        starBalText.text = starBallance.ToString();
    }

    // Returns the current Star Balance
    public int ReportStarBal()
    {
        return starBallance;
    }
}
