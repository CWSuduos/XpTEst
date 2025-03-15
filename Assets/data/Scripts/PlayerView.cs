using UnityEngine;
using TMPro;
using Zenject;

public class PlayerView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI xpText;
    [SerializeField] private TextMeshProUGUI levelText;

    private PlayerPresenter presenter;

    [Inject]
    public void Construct(PlayerPresenter presenter)
    {
        this.presenter = presenter;
    }

    public void UpdateXp(int xp)
    {
        xpText.text = $"XP: {xp}";
    }

    public void UpdateLevel(int level)
    {
        levelText.text = $"Level: {level}";
    }
}
