using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportRent
{
    class Shoes
    {
        int SizeShoe;
        string ColorShoe;
        int Price;

        protected Shoes(int SizeShoe, string ColorShoe, int Price)
        {
            this.SizeShoe = SizeShoe;
            this.ColorShoe = ColorShoe;
            this.Price = Price;
        }

        public override string ToString()
        {
            return String.Format("Size: {0}  Color: {1}  Price: {2}", SizeShoe, ColorShoe, Price);
        }
    }

    class Skates : Shoes
    {
        string TypeSkates;
        string ClassSkates;

        public Skates(string TypeSkates, string ClassSkates, int SizeShoe, string ColorShoe, int Price) : base(SizeShoe, ColorShoe, Price)
        {
            this.TypeSkates = TypeSkates;
            this.ClassSkates = ClassSkates;
        }

        public override string ToString()
        {
            Console.WriteLine(base.ToString());
            Console.WriteLine("Type: {0} , Class Skates: {1}", TypeSkates, ClassSkates);
            return null;
        }
    }

    class Boots : Shoes
    {
        string FunctionUse;
        int SizeThorns;
        string FormThorns;

        public Boots(string FunctionUse, int SizeThorns, string FormThorns, int SizeShoe, string ColorShoe, int Price) : base(SizeShoe, ColorShoe, Price)
        {
            this.FunctionUse = FunctionUse;
            this.SizeThorns = SizeThorns;
            this.FormThorns = FormThorns;
        }

        public override string ToString()
        {
            Console.WriteLine(base.ToString());
            Console.WriteLine("Function Use: {0}  SizeThorns: {1}  FormThorns: {2}", FunctionUse, SizeThorns, FormThorns);
            return null;
        }

    }

}

