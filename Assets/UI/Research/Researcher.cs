using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class Researcher : MonoBehaviour
{
    public bool clicked = false;
    public int PriceAtom = 0;
    public int UpkeepAtom = 0;
    public int EnergyAtom = 0;
    public int PollutionPerRoundAtom = 0;
    public int HappinessAtom = 0;

    public int PriceCoal = 0;
    public int UpkeepCoal = 0;
    public int EnergyCoal = 0;
    public int PollutionPerRoundCoal = 0;
    public int HappinessCoal = 0;

    public int PriceWind = 0;
    public int UpkeepWind = 0;
    public int EnergyWind = 0;
    public int PollutionPerRoundWind = 0;
    public int HappinessWind = 0;

    public void researched () {
        this.GetComponent<Image>().color = new Color(0.3443396f, 1, 0.9697767f, 1);
        clicked = true;
}
    public void researchable() {
        var tempColor = this.GetComponent<Image>().color;
        tempColor = Color.white;
        tempColor.a = 100f;
        this.GetComponent<Image>().color = tempColor;
    }


    public void twoPathsCheck(GameObject button) {
        if (button.GetComponent<Researcher>().clicked == true)
        {
            this.GetComponent<Researcher>().researched();
        }
    }

    public void Upgrade1Atom() {
        GameObject[] generators = (GameObject[]) GameObject.FindObjectsOfType<GameObject>().Where(obj => obj.name == "Atom(Clone)") ;
        for (int i = 0; i < generators.Length; i++) {
            generators[i].GetComponent<generatorBehavior>().Price = 100;
            PriceAtom = 100;
        }
    }
}
