using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TypeWriterEffect : MonoBehaviour
{
    public float delay = 0.1f;
    [TextArea(15, 20)]
    public string fullText;
    public GameObject Next;

    private string currentText = "";
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ShowText());
    }

    IEnumerator ShowText() {
        for (int i = 0; i < fullText.Length + 1; i++) {
            currentText = fullText.Substring(0, i);
            this.GetComponent<Text>().text = currentText;
            yield return new WaitForSeconds(delay);
        }
    }

    private void Update()
    {
        if (fullText.Equals(currentText)) {
            Next.SetActive(true);
        }
    }
}
