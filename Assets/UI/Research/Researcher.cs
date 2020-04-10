using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Researcher : MonoBehaviour
{
    public bool clicked = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

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

    public void Upgrade1Atom(GameObject Generator) {
        Generator.GetComponent<generatorBehavior>().Price = 100;
    }
}
