using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaskBar : MonoBehaviour
{

    public GameObject MusicPlayer;
    public GameObject WorkSapce;
    public GameObject ChatRoom;
    private int m;
    private int w;
    private int c;
    public Image MusicLayer;
    public Image WorkLayer;
    public Image ChatLayer;
    public GameObject OnPlayingMusic;
    private AudioSource Music;

    // Start is called before the first frame update
    void Start()
    {
         m=0;
         w=0;
         c=0;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MusicApp(){
        if(m==0){
            MusicPlayer.SetActive(true);
            m+=1;
            MusicLayer.color=new Color(1,0.55f,0,0.3f);
        }
        else{
            MusicPlayer.SetActive(false);
            m=0;
            MusicLayer.color=new Color(1,0.55f,0,0);

        }

    }
    public void WorkApp(){
        if(w==0){
            WorkSapce.SetActive(true);
            w+=1;
            WorkLayer.color=new Color(1,0.55f,0,0.3f);
        }
        else{
            WorkSapce.SetActive(false);
            w=0;
            WorkLayer.color=new Color(1,0.55f,0,0);

        }
    }
    public void ChatApp(){
        Music=OnPlayingMusic.GetComponent<SelectMusic>().OnPlayingMusic;
        if(c==0){
            ChatRoom.SetActive(true);
            c+=1;
            ChatLayer.color=new Color(1,0.55f,0,0.3f);
            Music.Pause();
        }
        else{
            ChatRoom.SetActive(false);
            c=0;
            ChatLayer.color=new Color(1,0.55f,0,0);

        }
    }


}
