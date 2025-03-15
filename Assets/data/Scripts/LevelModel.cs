[System.Serializable]
public class LevelModel
{
    public int CurrentLevel = 1;

    public void IncrementLevel()
    {
        CurrentLevel++;
    }
}
