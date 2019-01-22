using HoloToolkit.Unity.InputModule;
using HoloToolkit.Unity;
using UnityEngine;

public class BasicCubeController : MonoBehaviour, IInputClickHandler, IInputHandler
{
    public GameObject[] pieces;
    public GameObject win;
    public GameObject cursor;

    private int currentPiece = -1;

    private void Start()
    {
        InputManager.Instance.PushFallbackInputHandler(gameObject);
    }
    void OnEnable()
    {
        win.SetActive(false);
        resetPieces();
    }

    public virtual void OnInputClicked(InputClickedEventData eventData)
    {
        SoundManager.Instance.playTap();
        nextPiece();
    }
    public void OnInputDown(InputEventData eventData)
    { }
    public void OnInputUp(InputEventData eventData)
    { }

    private void resetPieces()
    {
        currentPiece = -1;
        updatePieces();
    }

    private void nextPiece()
    {
        cursor.SetActive(false);
        if (currentPiece < pieces.Length - 1)
        {
            currentPiece++;
            updatePieces();
        } else
        {
            SoundManager.Instance.playSuccess();
            cursor.SetActive(true);
            win.SetActive(true);
            resetPieces();
        }
    }

    private void previousPiece()
    {
        if (currentPiece > 0)
        {
            currentPiece--;
            updatePieces();
        }
    }

    public void updatePieces()
    {
        Debug.Log("Showing piece #" + currentPiece);
        for (int i = 0; i <= currentPiece; ++i)
        {
            win.SetActive(false);
            pieces[i].SetActive(true);
        }
        for (int i = currentPiece + 1; i < pieces.Length; ++i)
        {
            pieces[i].SetActive(false);
        }
    }
}