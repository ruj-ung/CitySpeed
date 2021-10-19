using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitySpeedLimit.Model
{
    public class Category
    {
        public int type { get; set; }
        public int Level { get; set; }
        public List<Item> ItemList { get; set; }

        public Category()
        {
            type = 0;
            ItemList = new List<Item>();
        }

        public void Evaluate()
        {
            if (type == 1) EvaluateConflict();
            if (type == 2) EvaluateActivity();

        }

        public override string ToString()
        {
            string result="";
            switch(Level)
            {
                case 0:
                    result = "High";
                    break;
                case 1:
                    result = "Moderate";
                    break;
                case 2:
                    result = "Low";
                    break;
            }
            return result;
        }
        private void EvaluateConflict()
        {
            if (ItemList[0].Checked || ItemList[1].Checked || ItemList[2].Checked || ItemList[3].Checked) Level = 0;
            else if (ItemList[4].Checked && ItemList[5].Checked && (ItemList[6].Checked || ItemList[7].Checked)) Level = 1;
            else if (ItemList[8].Checked && ItemList[9].Checked && ItemList[10].Checked && (ItemList[11].Checked || ItemList[12].Checked)) Level = 2;
            else Level = 2;
        }
        private void EvaluateActivity()
        {
            if (ItemList[0].Checked || ItemList[1].Checked || ItemList[2].Checked) Level = 0;
            else if (ItemList[3].Checked || ItemList[4].Checked || ItemList[5].Checked) Level = 1;
            else if (ItemList[6].Checked) Level = 2;
            else Level = 2;
        }
    }
}
