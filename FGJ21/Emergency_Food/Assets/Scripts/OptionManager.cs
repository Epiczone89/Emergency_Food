using UnityEngine;

public class OptionManager : MonoBehaviour
{
    public static OptionManager Instance { get; private set; }
    public float hungerRate = 1f;
    public float speedRate = 1f;
    public float carspeedRate = 1f;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            // GameObject isn't destroyed
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            GameObject.Destroy(this);
        }
    }
}
