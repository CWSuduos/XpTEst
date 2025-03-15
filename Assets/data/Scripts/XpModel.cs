[System.Serializable]
public class XpModel
{
    public int CurrentXp = 0;

    public void AddXp(int amount)
    {
        CurrentXp += amount;
    }
}
