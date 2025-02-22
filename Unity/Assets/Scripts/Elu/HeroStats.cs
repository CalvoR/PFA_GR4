﻿using UnityEngine;
using System.Collections;
using UnityEngine.Networking;


public static class HeroStats
{
    static float life;    
    static float endurance;     // en secondes de course possible
    static float attack;
    static float defense;
    static float speed;


    static HeroStats()
    {
        life = 100.0f;
        endurance = 5.0f;
        attack = 100.0f;
        defense = 100.0f;
        speed = 7.0f;
    }

    // Méthodes d'accès et de modification de chaque stat"

    public static float Life
    {
        get { return life; }
        set { life = value; }
    }

    public static float Endurance
    {
        get { return endurance; }
        set { endurance = value; }
    }

    public static float Attack
    {
        get { return attack; }
        set { attack = value; }
    }

    public static float Defense
    {
        get { return defense; }
        set { defense = value; }
    }

    public static float Speed
    {
        get { return speed; }
        set { speed = value; }
    }

    /// <summary>
    /// Fonction de vérification de l'endurance + màJ barre actuelle
    /// </summary>
    /// <param name="startRunningTime"></param>
    /// <returns></returns>
    public static bool isEnduranceFinished (float startRunningTime)
    {
        if (Time.time - startRunningTime > Endurance)
            return true;
        
        return false;
    }

    public static void takeDamage(int damage) {
        Life -= damage;
    }
}



