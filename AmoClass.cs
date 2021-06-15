using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;



namespace ProjektGame
{
    public class AmoClass
    {
        PictureBox AmoPicture;
        public int TopPosition;
        public int LeftPosition;

        Form1 mainform;

        public AmoClass(Form1 p_form)
        {
            mainform = p_form;
        }

        public void MakeAmo()
        {
            AmoPicture = new PictureBox();
            AmoPicture.Size = new Size(50, 50);
            AmoPicture.Tag = "Amo";
            AmoPicture.Image = Properties.Resources.Ammo;
            AmoPicture.SizeMode = PictureBoxSizeMode.Zoom;
            AmoPicture.Top = TopPosition;
            AmoPicture.Left = LeftPosition;
            mainform.Controls.Add(AmoPicture);
        }


    }
}
