using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Sugar
    {
        double sugarCost = .50;
        string sweetenerName;

        public double pullCost()
        {
            return sugarCost;

        }
        public void nameThatSweetener ()
        {
            sweetenerName = "sugar";
        
        }
        public string pullSugarName()
        {
            return sweetenerName;
        }
    }
}
