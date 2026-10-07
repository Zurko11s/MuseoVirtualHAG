using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Reflection.Metadata.Ecma335;
using Unity.VisualScripting;

public class Dialogue : MonoBehaviour
{

    [SerializeField] private TMP_Text dialogueText;
    [SerializeField] private Button nextButton;
    [SerializeField] private string[] dialogueLines;
    private float typingSpeed = 0.03f;

    private int currentLineIndex = 0;
    private bool isTyping = false;
    private Coroutine typingCoroutine;

    private void Start()
    {
        nextButton.onClick.AddListener(OnNextButtonClicked);
        StartDialogue();
        NiquiManager.instance.ActivateNiqui();
    }

    public void StartDialogue()
    {
        currentLineIndex = 0;
        if (dialogueLines.Length > 0)
        {
            PlayLine(currentLineIndex);
        }

    }

    private void OnNextButtonClicked()
    {
        if (isTyping)
        {
            CompleteCurrentLine();
        }
        else
        {
            currentLineIndex++;
            if (currentLineIndex < dialogueLines.Length)
            {
                PlayLine(currentLineIndex);
            }
            else
            {
                EndDialogue();
            }
        }
    }

    private void PlayLine(int index)
    {
        if (typingCoroutine != null)
        {
            StopCoroutine(typingCoroutine);
        }

        typingCoroutine = StartCoroutine(TypewriterEffect(dialogueLines[index]));
    }

    private IEnumerator TypewriterEffect(string textToType)
    {
        if(NiquiManager.instance.isMenuScene && ProgressionManager.instance.hasSeenMenuSceneBefore)
        {
            yield break;
        }
        isTyping = true;
        dialogueText.text = ""; 

        foreach (char letter in textToType.ToCharArray())
        {
            dialogueText.text += letter;
            AudioManager.instance.PlayTypewriter();
            yield return new WaitForSeconds(typingSpeed); 
        }

        isTyping = false;
    }

    private void CompleteCurrentLine()
    {
        if (typingCoroutine != null)
        {
            StopCoroutine(typingCoroutine);
        }

        dialogueText.text = dialogueLines[currentLineIndex];
        isTyping = false;
    }

    private void EndDialogue()
    {
        dialogueText.text = "";
        NiquiManager.instance.DeactivateNiqui();
    }
}
