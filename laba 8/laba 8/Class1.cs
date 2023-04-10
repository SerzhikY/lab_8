using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_8
{
    abstract class postcard
    {
        public postcard(string n)
        {
            this.Name = n;
        }
        public string Name { get; protected set; }
        public abstract string GetCost();
    }

    class Poorpostcard : postcard
    {
        public Poorpostcard() : base("Дешева листівка")
        { }
        public override string GetCost()
        {
            return "10";
        }
    }
    class Expensifepostcard : postcard
    {
        public Expensifepostcard()
            : base("Дорога листівка")
        { }
        public override string GetCost()
        {
            return "80";
        }
    }

    abstract class postcardDecorator : postcard
    {
        protected postcard postcard;
        public postcardDecorator(string n, postcard postcard) : base(n)
        {
            this.postcard = postcard;
        }
    }

    class Goldenpostcard : postcardDecorator
    {
        public Goldenpostcard(postcard p)
            : base(p.Name + ", з золотою рамкою", p)
        { }

        public override string GetCost()
        {
            return postcard.GetCost() + "30";
        }
    }

    class Silverpostcard : postcardDecorator
    {
        public Silverpostcard(postcard p)
            : base(p.Name + ", з срібною рамкою", p)
        { }

        public override string GetCost()
        {
            return postcard.GetCost() + "15";
        }
    }
}
