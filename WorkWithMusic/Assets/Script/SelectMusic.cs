using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectMusic : MonoBehaviour
{
    public AudioSource[] Music;
    public GameObject Dropdown;
    public int i;
    private int len;
    public Button Playing;
    public Sprite Play;
    public Sprite Pause;
    public AudioSource OnPlayingMusic;
    // Start is called before the first frame update
    void Start()
    {
      len=Music.Length;  
    }

    // Update is called once per frame
    void Update()
    {
        OnPlayingMusic=Music[i];
        if(Music[i].isPlaying){
        Playing.GetComponent<Image>().sprite=Pause;

        }
        else{
        Playing.GetComponent<Image>().sprite=Play;
    
        }
        
    }

    public void SelectedMusic(){
        for( i=0;i<len;i++){
            if(Music[i].isPlaying){

                Music[i].Stop();
            }
        }
        i=Dropdown.GetComponent<Dropdown>().value;
        Music[i].Play();
        gameObject.GetComponent<SimpleSpectrum>().audioSource=Music[i];
    }

    public void PlayMusic(){

        if(!Music[i].isPlaying){

            Music[i].Play();
            gameObject.GetComponent<SimpleSpectrum>().audioSource=Music[i];


        }
        else{
            Music[i].Pause();
        }
    }
}
