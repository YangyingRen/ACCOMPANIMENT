using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChatApp : MonoBehaviour
{
    public int maxMessages=25;
    public GameObject chatPanel, textObject;
    [SerializeField]
    public List<Message> messageList =new List<Message>();
    public float i=2;
    public float speed=0.1f;
    public AudioSource ReceiveMessage;
    public string[] Bargain;
    public string[] Talk;
    public string[] Respond;
    private int len;
    private int r;

    // Start is called before the first frame update
    void Start()
    {
    len=Bargain.Length;
    
        
    }

    // Update is called once per frame
    void Update()
    {   r=Random.Range(0,len);
        i-=speed*Time.deltaTime;
        if(i<=0){
            if(speed>=0.5f){
        SendMessageToChatAI(Bargain[r]);
  
            }
            else{
         SendMessageToChatAI(Talk[r]);}
         speed+=0.1f;
         i=2;
         ReceiveMessage.Play();

        }
        
        
    }
    public void SendMessageToChatAI(string text)
    {
        if(messageList.Count>maxMessages) {
            Destroy(messageList[0].textObject.gameObject);
            messageList.Remove(messageList[0]);
        }
        Message newMessage=new Message();
        newMessage.text=text;

        GameObject newTextAI=Instantiate(textObject, chatPanel.transform);
        newTextAI.GetComponent<Text>().alignment=TextAnchor.UpperLeft;
        newTextAI.GetComponent<Text>().text=text;
        newMessage.textObject =newTextAI.GetComponent<Text>();
        messageList.Add(newMessage);

    }
    public void SendMessageToChat(string text)
    {

        if(messageList.Count>maxMessages) {
            Destroy(messageList[0].textObject.gameObject);
            messageList.Remove(messageList[0]);
        }
        Message newMessage=new Message();
        newMessage.text=text;

        GameObject newText=Instantiate(textObject, chatPanel.transform);
        newText.GetComponent<Text>().alignment=TextAnchor.UpperRight;
        newText.GetComponent<Text>().text=text;
        newMessage.textObject =newText.GetComponent<Text>();
        messageList.Add(newMessage);

    }

    public void TestButton(){
        r=Random.Range(0,len);
        SendMessageToChat(Respond[r]);
        Debug.Log("Button");
        speed=0.1f;
        i=2;
        SendMessageToChatAI("Oh sorry, I don't mean to interrupt you.");

    }
}
[System.Serializable]
public class Message
{
    public string text;
    public Text textObject;
}
