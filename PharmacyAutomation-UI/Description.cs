using Microsoft.VisualBasic;
using PharmacyAutomation_DAL.Repositories;
using PharmacyAutomation_DATA.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyAutomation_UI
{
    public partial class Description : Form
    {
        public Description()
        {
            InitializeComponent();
        }

        BasketDetail basketDetail;
        public Description(BasketDetail _basketDetail)
        {

            basketDetail = _basketDetail;
            InitializeComponent();
        }


        List<string> selectedButton = new List<string>();
        BasketDetailRepository basketRepo;
        private void Description_Load(object sender, EventArgs e)
        {

            basketRepo = new BasketDetailRepository();

            if (basketDetail.ManualDescription != null)
            {
                selectedButton.AddRange(basketDetail.ManualDescription.Split(" /"));
                PullTheDescription();
            }
        }

        private void btnComeBack_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if ((chkEvening.Checked || chkMorning.Checked || chkAfternoon.Checked) && (rbFull.Checked || rbHungry.Checked))
            {
                if (basketDetail.ManualDescription == null)
                {
                    FillInDescription();
                    MessageBox.Show("Kaydedildi!");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else if (basketDetail.ManualDescription != null)
                {
                    basketDetail.ManualDescription = "";
                    FillInDescription();
                    MessageBox.Show("Değişiklik Kaydedildi!");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }

            }
            else
            {
                MessageBox.Show("Açlık ve Zaman olarak işaretlemeniz Gerekiyor");

            }


        }



        private void PullTheDescription()
        {

            foreach (Control item in this.Controls)
            {

                if (item is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)item;
                    if (selectedButton.Contains(checkBox.Tag))
                    {
                        checkBox.Checked = true;
                    }

                }
                else if (item is RadioButton)
                {
                    RadioButton radioButton = (RadioButton)item;
                    if (selectedButton.Contains(radioButton.Tag))
                    {
                        radioButton.Checked = true;

                    }
                }
            }

        }

        private void FillInDescription()
        {
            foreach (Control button in this.Controls)
            {
                if (button is CheckBox)
                {
                    CheckBox btn = (CheckBox)button;
                    if (btn.Checked)
                    {
                        basketDetail.ManualDescription += btn.Text + " /";
                    }
                }
            }
            if (rbHungry.Checked)
            {

                basketDetail.ManualDescription += $"{rbHungry.Tag.ToString()}";

            }
            else
            {
                basketDetail.ManualDescription += $"{rbFull.Tag.ToString()}";

            }

        }
    }
}
