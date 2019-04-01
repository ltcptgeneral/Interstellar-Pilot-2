using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;
using System.Linq;
using UnityEngine.UI;

public class loadData : MonoBehaviour
{
    [SerializeField]
    public string path;
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

    public GameObject buttonTemplate;

    //Debug.Log(files.Length);

    void Start()
    {
        nameText.enabled = false;
        dateText.enabled = false;
        subheaderText.enabled = false;
        descriptionText.enabled = false;
        subheaderLables.enabled = false;
        Object[] files = Resources.LoadAll(path, typeof(TextAsset)).ToArray();
        StreamReader reader;
        //CSVReader reader = new CSVReader();

        for (int i = 0; i < files.Length; i++) {
            GameObject button = Instantiate(buttonTemplate) as GameObject;
            button.SetActive(true);

            //reader = new StreamReader(files[i]);
            //string fileText = reader.ReadToEnd();

            //string fileText = files[i].Text;

            string fileText = System.IO.File.ReadAllText("Assets/Resources/gameData/tutorials/data/" + files[i].name + ".txt");
            string[,] parsed = CSVReader.SplitCsvGrid(fileText);
            //Debug.Log(parsed[0,0]);

            button.GetComponent<buttonBehavior>().SetText(files[i].name);
            if (parsed[0,0].Equals("1"))
            {

                button.GetComponent<buttonCompleteBehavior>().SetComplete(true);

            }
            else
            {

                button.GetComponent<buttonCompleteBehavior>().SetComplete(false);

            }
            
            button.transform.transform.SetParent(buttonTemplate.transform.parent, false);
        }

        //foreach (var t in files)
        //{
        //    Debug.Log(t.name);
        //}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
