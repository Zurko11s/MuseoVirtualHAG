using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement; 

public class DialogoDiversidad : MonoBehaviour
{
    public int mainInt = 1;
    public TMP_Text dialogo1;
    public TMP_Text dialogo2;
    public GameObject niqui1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Next(){
        mainInt += 1;
         if (mainInt == 1){
                // audioSource1.Play();
        }
        else if (mainInt == 2){
                dialogo1.text = "Este lugar es muy especial para mí. Aquí guardo todos esos momentos en los que me vi junto a otros como yo. Personas diferentes. Siempre agradecí que, al menos en un lugar, pudiéramos ser quienes somos libremente.";
        }
    }
}
