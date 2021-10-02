using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReceivedMessage : MonoBehaviour
{

    public Animator Message;
    public AudioSource call;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(call.isPlaying){
            Message.SetBool("Message",true);


        }
        else{
            Message.SetBool("Message",false);

        }
    }
}
