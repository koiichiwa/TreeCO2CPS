using UnityEngine;
using TMPro;

public class RandomFactGenerator : MonoBehaviour
{
 
    public TextMeshProUGUI factText;

 
    public string[] facts = new string[]
    {
        "A tree can absorb anywhere from 10 to 40kg of CO2 in a year.",
        "Transport is the 2nd highest emitter of Greenhouse Gases in Canada.",
        "The average Canadian produces the equivalent of 14.2 tons of CO2 every year.",
        "Each liter of gasoline a car burns puts 2.3kg of CO2 in the atmosphere.",
        "Maintaining a steady amount of CO2 allows the Earth to avoid becoming a second Venus."
    };

    void Start()
    {
        DisplayRandomFact();
    }
    public void DisplayRandomFact()
    {
        if (facts.Length == 0)
        {
            factText.text = "No facts available!";
            return;
        }

        int randomIndex = Random.Range(0, facts.Length);
        factText.text = facts[randomIndex];
    }
}
