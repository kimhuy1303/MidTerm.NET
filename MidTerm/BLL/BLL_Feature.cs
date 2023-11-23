using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm
{
    public class BLL_Feature
    {
        DAO_Feature dFeature;
        
        public BLL_Feature() 
        { 
            dFeature = new DAO_Feature();
        }

        public void displayFeatureList(CheckBox checkBox, FlowLayoutPanel pn)
        {
            var features = dFeature.GetFeatureList();
            Const.Features = new List<Feature>();
            foreach (Feature feature in features)
            {
                checkBox = new CheckBox();
                checkBox.Text = feature.FeatureName;
                checkBox.Tag = feature;
                checkBox.AutoSize = true;
                checkBox.Font = new FormChuongTrinh().font;
                checkBox.CheckedChanged += CheckBox_CheckedChanged;
                pn.Controls.Add(checkBox);
                
            }
        }

        private void CheckBox_CheckedChanged(object? sender, EventArgs e)
        {
            CheckBox? checkBox = sender as CheckBox;
            if (checkBox!.Checked) 
            {
                Const.Features?.Add(checkBox.Tag as Feature);
            }
            if (!checkBox.Checked)
            {
                if (Const.Features.Contains(checkBox.Tag as Feature))
                {
                    Const.Features.Remove(checkBox.Tag as Feature);
                }
            }
        }
    }
}
