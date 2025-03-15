using System;
using UnityEngine;

[Serializable]
public class PlayerData
{
    [SerializeField] private int level;
    [SerializeField] private int xp;

    public int Level => level;
    public int Xp => xp;

    public void SetLevel(int newLevel) => level = newLevel;
    public void SetXp(int newXp) => xp = newXp;
}

