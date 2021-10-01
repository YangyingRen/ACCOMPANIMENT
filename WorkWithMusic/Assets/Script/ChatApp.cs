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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
        newText.GetComponent<Text>().text=text;
        newMessage.textObject =newText.GetComponent<Text>();
        messageList.Add(newMessage);

    }
    public void TestButton(){
        SendMessageToChat("Test");
        Debug.Log("Button");
    }
}
[System.Serializable]
public class Message
{
    public string text;
    public Text textObject;
}
