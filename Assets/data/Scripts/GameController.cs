using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI xpText, levelText;
    [SerializeField] private Button increaseXpButton;
    [SerializeField] private PlayerPresenter playerPresenter;

    private void Start()
    {
        if (increaseXpButton != null)
            increaseXpButton.onClick.AddListener(() => { playerPresenter.AddXp(1); UpdateUI(); });
        UpdateUI();
    }

    private void UpdateUI()
    {
        if (xpText != null && levelText != null)
        {
            xpText.text = $"XP: {playerPresenter.CurrentXp}";
            levelText.text = $"Level: {playerPresenter.CurrentLevel}";
        }
    }
}
