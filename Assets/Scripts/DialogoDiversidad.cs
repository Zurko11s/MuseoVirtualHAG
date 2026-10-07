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
        Next();
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
                dialogo1.text = "Este lugar es muy especial para mí. Aquí guardo todos esos momentos en los que me vi junto a otros como yo. Personas diferentes. Siempre agradecí que, al menos en un lugar, pudiéramos ser quienes somos libremente. Eso es realmente lo que quiero mostrarte. Me gustaría que veas un poco de lo que nos hace diferentes, del arte y como lo expresamos todos de múltiples formas.";
        }
        else if (mainInt == 3){
			dialogo1.text = "A esto me refiero. Aquí todos nos vemos y actuamos muy distinto, pero no está mal. Somos amigos incluso si a veces es difícil entendernos. Es algo que necesitamos aprender de alguien. Afuera, muchas veces, nos enseñan que la diferencia es algo negativo, que es un peligro o motivo de burla. Pero gracias a este tipo de cosas podemos ver que no es nada de eso, que la diversidad son solo muchas formas de expresar lo mismo y que en el fondo no somos tan diferentes como nuestros rostros." ;
		}
		else if (mainInt == 4){
			dialogo1.text = "Al igual que todos en este país, la diversidad nos hace más interesantes, más fuertes. No soy una réplica tuya, ni tú una réplica mía; y eso me hace feliz. Me gusta ser quien soy tanto como a tí te gusta ser quien eres. Y claro, no solo somos diversos nosotros. Una de mis cosas favoritas es lo bella que es la naturaleza. Lo diferente que son entre ellos los animales y las plantas." ;
		}
				else if (mainInt == 5){
			dialogo1.text = "Es bastante lindo ¿No crees?. Siempre me siento mejor cuando paso por aquí. Es un recuerdo de lo lindo que es no solo este país, sino toda América. Me recuerda un poco nuestras raíces con la tierra y, desde luego, nuestras responsabilidades con ella. ¡Y aún te queda mucho por ver!. Por ejemplo, estos murales siempre me han parecido hermosos. Muestran perfectamente lo diversas que son otras cosas. No sólo nuestra apariencia o costumbres son distintas, sino que nuestros estilos y pensamientos pueden ser completamente diferentes o hasta opuestos." ;
		}
    }
}
