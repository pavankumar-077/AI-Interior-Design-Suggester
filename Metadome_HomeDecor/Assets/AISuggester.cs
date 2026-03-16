using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class AISuggester : MonoBehaviour
{
    public TMP_InputField styleInput;
    public TextMeshProUGUI suggestionText;

    public FurnitureManager furnitureManager;

    public Button option1;
    public Button option2;
    public Button option3;

    public void GenerateSuggestion()
    {
        string style = styleInput.text.ToLower();

        if (style.Contains("modern"))
        {
            suggestionText.text = "Choose a Modern Option";

            option1.gameObject.SetActive(true);
            option2.gameObject.SetActive(true);
            option3.gameObject.SetActive(true);

            option1.onClick.RemoveAllListeners();
            option2.onClick.RemoveAllListeners();
            option3.onClick.RemoveAllListeners();

            option1.onClick.AddListener(() => furnitureManager.ApplyModernLight());
            option2.onClick.AddListener(() => furnitureManager.ApplyModernDark());
            option3.onClick.AddListener(() => furnitureManager.ApplyModernLuxury());

            option1.GetComponentInChildren<TextMeshProUGUI>().text = "Light Modern";
            option2.GetComponentInChildren<TextMeshProUGUI>().text = "Dark Modern";
            option3.GetComponentInChildren<TextMeshProUGUI>().text = "Luxury Modern";
        }
        else if (style.Contains("minimal"))
        {
            suggestionText.text = "Choose a Minimal Option";

            option1.gameObject.SetActive(true);
            option2.gameObject.SetActive(true);
            option3.gameObject.SetActive(true);

            option1.onClick.RemoveAllListeners();
            option2.onClick.RemoveAllListeners();
            option3.onClick.RemoveAllListeners();

            option1.onClick.AddListener(() => furnitureManager.ApplyMinimalWhite());
            option2.onClick.AddListener(() => furnitureManager.ApplyMinimalGrey());
            option3.onClick.AddListener(() => furnitureManager.ApplyMinimalWood());

            option1.GetComponentInChildren<TextMeshProUGUI>().text = "White Minimal";
            option2.GetComponentInChildren<TextMeshProUGUI>().text = "Grey Minimal";
            option3.GetComponentInChildren<TextMeshProUGUI>().text = "Wood Minimal";
        }
        else
        {
            suggestionText.text = "Style not recognized.";
        }
    }
}