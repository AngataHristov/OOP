
namespace Blobs.Models.Units
{
    using System;
    using Enumerations;
    using Interfaces;

    public class Blob : IBlob
    {
        private const int defaultTurnsCounter = 0;

        private string name;
        private int health;
        private int damage;
        private IAttack attack;
        private IBehavior behavior;
        private int defaultHealth;
        private int defaultDamage;

        public Blob(string name, int health, int damage, IAttack attack, IBehavior behavior)
        {
            this.Name = name;
            this.Health = health;
            this.Damage = damage;
            this.Attack = attack;
            this.Behavior = behavior;
            this.TurnsCounter = defaultTurnsCounter;
            this.defaultHealth = health;
            this.defaultDamage = damage;
            this.IsAlive = true;
        }

        public bool IsAlive { get; set; }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(Messages.InvalidNameArguments);
                }

                this.name = value;
            }
        }

        public int Health
        {
            get
            {
                return this.health;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(Messages.InvalidHealthArguments);
                }

                this.health = value;
            }

        }

        public int Damage
        {
            get
            {
                return this.damage;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(Messages.InvalidDamageArguments);
                }

                this.damage = value;
            }
        }

        public IAttack Attack
        {
            get
            {
                return this.attack;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(Messages.InvalidAttackArguments);
                }

                this.attack = value;
            }
        }

        public IBehavior Behavior
        {
            get
            {
                return this.behavior;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(Messages.InvalidBehaviorArguments);
                }

                this.behavior = value;
            }
        }

        public int TurnsCounter { get; private set; }

        public void Update()
        {
            this.TurnsCounter++;

            if (!this.Behavior.IsTriggered && this.Health <= this.defaultHealth)
            {
                this.Behavior.IsTriggered = true;

                if (this.Behavior.Types == BehaviorTypes.Aggressive)
                {
                    this.Damage = 2 * this.defaultDamage;

                    if (this.Damage < this.defaultDamage)
                    {
                        this.Damage = this.defaultDamage;
                    }
                }

                if (this.Behavior.Types == BehaviorTypes.Inflated)
                {
                    this.Health += 50;
                }
            }

            // if (this.Behavior.IsTriggered && this.Behavior.Types == BehaviorTypes.Aggressive)
            // {
            //     this.Damage -= 5;
            // }
            // 
            // if (this.Behavior.IsTriggered && this.Behavior.Types == BehaviorTypes.Inflated)
            // {
            //     this.Health -= 10;
            // 
            //     if (this.Health < 0)
            //     {
            //         this.Health = 0;
            //     }
            // }
        }
        public override string ToString()
        {
            return string.Format("Blob {0}: {4} HP, {2} Damage", this.Name, this.Health, this.Damage);
        }
    }
}
