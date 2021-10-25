using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameControler : MonoBehaviour
{
    public GameObject introScreen;
    public GameObject gameScreen;

    public float cronometro = 0.0f;
    public bool isPlaying = false;
    
    public TextMeshProUGUI labelCrono;
    public TextMeshProUGUI labelResultado;
    public TextMeshProUGUI textPlayButton;  //public TextMeshProUGUI = textPlayButton;
    public TextMeshProUGUI scoreGoals;
    

    // para 2 jugadores
    public TextMeshProUGUI infoGame;

    private int goalPlayer1 = 0;
    private int goalPlayer2 = 0;
    private int playerTurn = 1;

    

    // Start is called before the first frame update
    void Start()
    {
        labelResultado.text = ""; //para que la etiqueta esté vacia
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlaying == true) //ponemos if para que no empice cuando le demos a play
        {
            cronometro += Time.deltaTime;
            labelCrono.text = cronometro.ToString("0.0000"); //pongo los numeros decimales a los que quiero limitar
        }
        
    }


    public void EnterGame()
    {
        introScreen.SetActive(false);
        gameScreen.SetActive(true);
    }

    public void ClickButtonPlay()
    {
        isPlaying = !isPlaying; //! pone el valor contrario
        if(isPlaying)
        {
            textPlayButton.text = "soltar balon";
        }
        else
        {
            textPlayButton.text = "jugar";
            //labelResultado.text = "mostrar resultado de la jugada";   s epuede hacer aqui o en otra funcion get result
            labelResultado.text = GetResult(cronometro);
        }
    }

    public float GetDecimals(float number)
    {
       
        return number % 1; //% me da el resto de la division
    }

    
    
    public string GetResult(float time)  // el time es el crono
    {
        string resultado = "Mostrar resultado jugada";

        float decimals = GetDecimals(time);

        if(decimals>=0.0f & decimals <= 0.25f)
        {
            resultado = "GOOL!"; // juego 2 personas: 
            infoGame.text = "saca de centro campo el jugador" + playerTurn;

            // aumentar goles
            ScoreGoals();
            //actualiza marcador
            UpdateScoreGoals();

            // cambia jugador
            UpdatePlayerTurn();
        }

        else if(decimals >= 0.26f & decimals <= 0.75f)
        {
            resultado = "fuera";
            //actualiza info game
            infoGame.text = "saca de banda el jugador" + playerTurn;

            //cambia jugador
            UpdatePlayerTurn();
        }

        else
        {
            resultado = "falta";
            infoGame.text = "saca falta el jugador" + playerTurn;
        }

        return resultado;
    }

    private void ScoreGoals() // para aumentar puntos
    {
        // si turno jugador =1 
                //aumentar goler jugador 1
        
        // si turno jugador=2
            // aumentar goler jugador =2

        if(playerTurn==1)
        {
            goalPlayer1++;
        }

        if(playerTurn==2)
        {
            goalPlayer2++;
        }
    }


    public void UpdatePlayerTurn()
    {
        if(playerTurn==1) //tamb se puede hacer con un booleano
        {
            playerTurn = 2;
        }
        else
        {
            playerTurn = 1;
        }
    }

    private void UpdateScoreGoals()
    {
        textScoreBoard.text = goalsPlayer1 + " :" + golasPlayer2;
    }

}
