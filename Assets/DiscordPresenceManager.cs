using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Discord;

public class DiscordPresenceManager : MonoBehaviour
{
    public Discord.Discord discord;

    // Use this for initialization
    void Start()
    {
        discord = new Discord.Discord(740120236992364576, (System.UInt64)Discord.CreateFlags.Default);
        var activityManager = discord.GetActivityManager();
        var activity = new Discord.Activity
        {
            State = "유니티 디스코드 Rich Presence 테스트",
            Details = "테스트"
        };
        activityManager.UpdateActivity(activity, (res) =>
        {
            if (res == Discord.Result.Ok)
            {
                Debug.Log("Success");
            }
        });
    }

    // Update is called once per frame
    void Update()
    {
        discord.RunCallbacks();
    }
}
