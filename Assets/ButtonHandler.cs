using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ButtonHandler : MonoBehaviour
{
    public Button m_YourFirstButton, m_YourSecondButton, m_YourThirdButton, m_YourFourthButton,m_QuitButton,color;
    public TMP_Text ScoreCounter, ColorCounter;
    public int score, colr;
    public GameObject myPrefab,myPrefab2;
    public Transform canvas;
        public Image panel;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        score = 0;
        colr=0;
        m_YourFirstButton.onClick.AddListener(TaskOnClick);
        m_YourSecondButton.onClick.AddListener(delegate {TaskWithParameters("Hello");});
        m_YourThirdButton.onClick.AddListener(()=>ButtonClicked(42));
        m_YourThirdButton.onClick.AddListener(TaskOnClick);
        m_YourFourthButton.onClick.AddListener(RollCredits);
        m_QuitButton.onClick.AddListener(QuitButtonOnClick);
        color.onClick.AddListener(changeColor);

    }
    void changeColor()
    {
        if (score >=5)
        {
            panel.color = Random.ColorHSV();
            score -=5;
            colr+=1;
            ScoreCounter.text = "Score: "+score;
            ColorCounter.text = "Colors: "+colr;
        } else
        {
            Debug.Log("not enough points");
        }
        
    }
    void RollCredits()
    {
        Debug.Log("roll");
        Instantiate(myPrefab);
    }
    void TaskOnClick(){
        Debug.Log("Theoretically start game");

    }
    void TaskWithParameters(string message){
        Debug.Log(message);
        score +=1;
        ScoreCounter.text = "Score: "+score;
    }
    void ButtonClicked(int buttonNo){
        Debug.Log("Button clicked="+buttonNo);
        Instantiate(myPrefab2);
    }

    void QuitButtonOnClick(){
        Debug.Log("quit");
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
