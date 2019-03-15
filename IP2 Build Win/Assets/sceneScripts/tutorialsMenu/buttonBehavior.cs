using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class buttonBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    [SerializeField]
    private Text buttonText;
    [SerializeField]
    private Text nameText;
    [SerializeField]
    private Text dateText;
    [SerializeField]
    private Text subheaderText;
    [SerializeField]
    private Text descriptionText;
    [SerializeField]
    private Text subheaderLables;

    public void SetText(string text)
    {
        buttonText.text = text;
    }

    public void OnClick()
    {
        nameText.enabled = true;
        dateText.enabled = true;
        subheaderText.enabled = true;
        descriptionText.enabled = true;
        subheaderLables.enabled = true;

        string fileText = System.IO.File.ReadAllText("Assets/Resources/gameData/tutorials/data/" + buttonText.text + ".txt");
        string[,] parsed = CSVReader.SplitCsvGrid(fileText);

        nameText.text = buttonText.text;
        dateText.text = parsed[1, 0];
        subheaderText.text = parsed[2, 0] + "\n" + parsed[3, 0] + "\n" + parsed[5, 0];
        descriptionText.text = parsed[5, 0];
    }
}
