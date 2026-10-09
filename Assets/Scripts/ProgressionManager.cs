using UnityEngine;

public class ProgressionManager : MonoBehaviour
{
    public static ProgressionManager instance;

    public bool hasSeenMenuSceneBefore = false;
    public bool hasSeenMigration = false;
    public bool hasSeenDiversity = false;
    public bool hasSeenMovility = false;
    public bool hasSeenInclusion = false;
    public bool canSeeEnding = false;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        } else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    private void FixedUpdate()
    {
        if(hasSeenMigration && hasSeenMovility && hasSeenDiversity && hasSeenInclusion)
        {
            canSeeEnding = true;
        }
    }

}
