using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class Researcher : MonoBehaviour
{
    public bool clicked = false;

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

    public void Upgrade1Atom(GameObject generator) {
        generator.GetComponent<generatorBehavior>().Price = 100;
        generatorBehavior[] placedbehaviour = GameObject.FindObjectsOfType<generatorBehavior>();
        for (int i = 0; i < placedbehaviour.Length; i++) 
        {
            if (placedbehaviour[i].name == generator.name + "(Clone)") {
                placedbehaviour[i].Price = 100;
            }
        }
    }
}
