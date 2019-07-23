using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderButton : MonoBehaviour
{
    // Variables
    [SerializeField] GameObject defender;

    //Cache
    GameObject icon;
    DefenderSpawner defenderSpawner;

    
    // Start is called before the first frame update
    void Start()
    {
        icon = this.gameObject;
        defenderSpawner = FindObjectOfType<DefenderSpawner>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Detects when the object is clicked on by the mouse
    private void OnMouseDown()
    {
        SetColor();
        SetDefender();
    }

    private void SetColor()
    {
        var buttons = FindObjectsOfType<DefenderButton>();
        foreach (DefenderButton button in buttons)
        {
            button.GetComponent<SpriteRenderer>().color = new Color32(87, 87, 87, 255);
        }
        icon.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
    }

    // Sets the defender GameObject in the DefenderSpawner script
    private void SetDefender()
    {
        defenderSpawner.ChangeDefender(defender);
    }
}
