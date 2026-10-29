using UnityEngine;

public class UIPlayer : MonoBehaviour
{
    
    public string playerName;

    public TMP_inputField nameInput;

    public bool poisoned;

    public string[] myInventory;

    public void Awake()
    {
        myInventory = newString[5]
    }

    public void ChangeName()
    {
        playerName = nameInput.text;
    }

    public void FlipPoison(bool b)
    {
        poisoned = b;
    }   

    public void AddToInventory(string s)
    {
        for (int i = 0; i < myInventory.Length; i++)
        {
            if (myInventory[i] == " ")
            {
                myInventory[i] = s;
                break;
            }

        }
        foreach(string j in myInventory)
        {
            Debug.log("holding: " + j)
        }

    }


}
