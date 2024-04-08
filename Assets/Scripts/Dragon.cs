using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    public class Dragon : Person
    {
        public Dragon(string name, int health) : base(name, health)
        {
        }

        public override void TakeDamage(int damageValue)
        {
            Debug.Log("I, the mighty dragon, have lost: " + damageValue + " hit points from a hunter's shot");
            ChangeHealth(-damageValue);
        }

        void Start()
        {

        }
    }
}