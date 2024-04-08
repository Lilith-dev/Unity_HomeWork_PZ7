using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        Dragon dragon = gameObject.AddComponent<Dragon>();
        dragon.SetName("Дурник-Летючий");
        dragon.Health = 80;

        dragon.PrintInfo();
        dragon.ShowStat();

        dragon.ChangeHealth(20);
        dragon.PrintInfo();

        dragon.ChangeHealth(-30);
        dragon.PrintInfo();


        Player player = gameObject.AddComponent<Player>();
        player.SetName("Дурник");
        player.Health = 80;

        player.PrintInfo();
        player.ShowStat();

        player.ChangeHealth(20);
        player.PrintInfo();

        player.ChangeHealth(-30);
        player.PrintInfo();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
