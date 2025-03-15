using UnityEngine;

public class PlayerPresenter : MonoBehaviour
{
    public XpModel xpModel;
    public LevelModel levelModel;

    public void AddXp(int amount)
    {
        xpModel.AddXp(amount);
        if (xpModel.CurrentXp >= 100) 
        {
            xpModel.CurrentXp = 0;
            levelModel.IncrementLevel();
        }
    }

    public int CurrentXp => xpModel.CurrentXp;
    public int CurrentLevel => levelModel.CurrentLevel;
}
