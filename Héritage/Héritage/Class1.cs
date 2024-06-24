using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Héritage
{
    public abstract class Animal
    {
        protected string Name { get; }
        protected int LegsCount { get; }
        protected bool Hairy { get; }

        public Animal(string name, int legsCount, bool hairy)
        {
            this.Name = name;
            this.LegsCount = legsCount;
            this.Hairy = hairy;
        }

        public virtual string Move()
        {
            return $"Le/l'{this.Name} se déplace à {LegsCount} pattes"; 
        }

        public string Eat()
        {
            return "L'animal mange avec la bouche";
        }
    }


    public class Bipede : Animal
    {
        public Bipede(string name) : base(name, 2, true)
        { }

        public override string Move()
        {
            return base.Move();
        }
    }

    public class Quadrupede : Animal
    {
        public Quadrupede(string name) : base(name, 4, false)
        { }

        public override string Move()
        {
            return base.Move();
        }

    }

}
