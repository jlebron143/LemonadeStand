using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Sugar
    {
        double priceOfSugar = .50;
        string sweetenerName;

        public double pullCost()
        {
            return priceOfSugar;

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
