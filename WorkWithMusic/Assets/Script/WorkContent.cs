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
    private AudioSource Music;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { if(OnPlayingMusic.GetComponent<SelectMusic>().OnPlayingMusic!=null){
        Music=OnPlayingMusic.GetComponent<SelectMusic>().OnPlayingMusic;
        if(InputField.GetComponent<InputField>().text!=null){
        if(Input.anyKey){
               Music.volume+=0.01f;
           }
        else{
               Music.volume-=0.01f*Time.deltaTime;
           }

       }
    }
        WrittenText.text=TypeText.text;
    
       SampleText.text=Plot[i].text;
       if(WrittenText.text==SampleText.text){
           if(Input.GetKeyDown(KeyCode.Return)){
               i+=1;
               
           }
       }




        
        
    }
}
