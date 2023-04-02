using FontAwesome.Sharp;
using System;
using System.Data;


namespace FlatUiUserInterface
{
    public partial class Form1 : Form
    {
        private IconButton currentButton;
        private Panel leftBorderBtn;
        public Form1()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
        }

        // color struct
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
        private void ActiveButton(object senderBtn, Color color)
        {
            if(senderBtn != null)
            {
                ButtonOff();
                //Button
                currentButton = (IconButton)senderBtn;
                currentButton.BackColor = Color.FromArgb(37, 36, 81);
                currentButton.ForeColor = color;
                currentButton.TextAlign = ContentAlignment.MiddleCenter;         
                currentButton.IconColor = color;
                currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentButton.ImageAlign = ContentAlignment.MiddleRight;
                // left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentButton.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        private void ButtonOff()
        {
            if(currentButton != null)
            {
                currentButton.BackColor = Color.FromArgb(31, 30, 68);
                currentButton.ForeColor = Color.Gainsboro;
                currentButton.TextAlign = ContentAlignment.MiddleLeft;
                currentButton.IconColor = Color.Gainsboro;
                currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentButton.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color1);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color2);
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color3);
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color4);
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color5);
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color6);
        }
    }
}