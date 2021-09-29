using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WorkContent : MonoBehaviour
{

    public Text WrittenText;
    public Text TypeText;
    public Text SampleText;
    public Text[] Plot;
    private int i=0;
    public GameObject InputField;
    public GameObject OnPlayingMusic;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   AudioSource Music=OnPlayingMusic.GetComponent<SelectMusic>().OnPlayingMusic;
        WrittenText.text=TypeText.text;
       if(InputField.GetComponent<InputField>().text!=null){
           if(Input.anyKey){
               Music.volume+=0.01f;
           }
           else{
               Music.volume-=0.005f*Time.deltaTime;
           }

       }
       SampleText.text=Plot[i].text;
       if(WrittenText.text==SampleText.text){
           if(Input.GetKeyDown(KeyCode.Return)){
               i+=1;
           }
       }




        
        
    }
}
