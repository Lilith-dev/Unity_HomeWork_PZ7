using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using UnityEngine;

namespace Assets.Scripts
{
    public class Player : Person
    {
        private int _experience;

        public Player(string name, int health, int experience): base(name, health)
        {
            _experience = experience;
        }

        public int Experience
        {
            get { return _experience; }
        }
        public override void ShowStat()
        {
            Debug.Log("Ім'я: " + Name + ", Досвід: " + Experience);
        }

        public override void TakeDamage(int damageValue)
        {
            ChangeHealth(-damageValue);
            Debug.Log("My name is " + Name + ". After hitting with force: " + damageValue + " I have health: " + Health);
        }

        void Start()
        {

        }
    }
}
