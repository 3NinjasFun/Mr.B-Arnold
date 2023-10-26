using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class TimmyWork : MonoBehaviour
{
    public Button buttonA;
    public Button buttonB;
    public Button buttonC;
    public Button buttonD;
    public Button buttonF;
    public GameObject grades;
    public GameObject prompt;
    public GameObject responseA;
    public GameObject responseB;
    public GameObject responseC;
    public GameObject responseD;
    public GameObject responseF;
   // public GameObject gradingTimmy;

    
    public TextMeshPro Response;
    // Start is called before the first frame update
    void Start()
    {
       /*grades =  GameObject.Find("Grades");
       prompt = GameObject.Find("Prompt");
        responseA = GameObject.Find("ResponseA");
        responseB = GameObject.Find("ResponseB");
        responseC = GameObject.Find("ResponseC");
        responseD = GameObject.Find("ResponseD");
        responseF = GameObject.Find("ResponseF");*/
    }
    public void gradeA()
    {
        responseA.SetActive(true);
    }
    public void gradeB() 
    { 
        responseB.SetActive(true); 
    }
    public void gradeC() 
    {
        responseC.SetActive(true);
    }
    public void gradeD() 
    {
        responseD.SetActive(true);
    }
    public void gradeF() 
    { 
        responseF.SetActive(true);
    }


    // Update is called once per frame
    void Update()
    {
       
    }

   /* private void OnCollisionEnter(Collision collision)
    {
        gradingTimmy.SetActive(true);
    }*/
}
