using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OpenAI;
using TMPro;
using UnityEngine.Events;

public class ChatGPTManager : MonoBehaviour
{
    public OnResponseEvent onResponse;

    [SerializeField]
    public string APIKey;
    


    [System.Serializable]
    public class OnResponseEvent : UnityEvent<string> { };

    private List<ChatMessage> messages = new List<ChatMessage> ();
    


    public async void AskChatGPT (TMP_Text newText)
    {
        var openai = new OpenAIApi(APIKey);
        ChatMessage newMessage = new ChatMessage();
        newMessage.Content = "Responda a seguinte pergunta sobre astronomia e áreas correlatas como se fosse para um aluno do ensino fundamental, no máximo 10 linhas: " + newText.text +"caso a pergunta não tenha relação com astronomia, diga que não pode responder.";
        newMessage.Role = "user";

        messages.Add(newMessage);

        CreateChatCompletionRequest request = new CreateChatCompletionRequest();
        request.Messages = messages;
        request.Model = "gpt-3.5-turbo";

        var response = await openai.CreateChatCompletion(request);

        if(response.Choices != null && response.Choices.Count > 0)
        {
            var chatResponse = response.Choices[0].Message;
            messages.Add(chatResponse);

            Debug.Log(chatResponse.Content);

            onResponse.Invoke(chatResponse.Content);
        }
    }
  
}
