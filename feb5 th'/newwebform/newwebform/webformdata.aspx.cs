﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace newwebform
{
    public partial class webformdata : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string data = " ";
            string name = TxtName.Text;
            string dob = Calendar1.SelectedDate.ToString();
            string gender = RadioButtonList1.SelectedItem.Value.ToString();
            string hobby = " ";
            if (CheckBoxList1.Items[0].Selected)
            {
                hobby += CheckBoxList1.Items[0].Value;
            }

            if (CheckBoxList1.Items[1].Selected)
            {
                hobby += CheckBoxList1.Items[1].Value;
            }
            if (CheckBoxList1.Items[2].Selected)
            {
                hobby +="\n"+ CheckBoxList1.Items[2].Value;
            }

            if (CheckBoxList1.Items[3].Selected)
            {
                hobby += "\n" + CheckBoxList1.Items[3].Value;
            }
            string education = DropDownList1.SelectedValue.ToString();
            data += name + "\n" + gender +"\n"+ hobby + "\n" + education;
            lblDisplay.Text=data;
        }

       
    }
}