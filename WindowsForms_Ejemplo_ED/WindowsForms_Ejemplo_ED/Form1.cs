using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_Ejemplo_ED
{
    public partial class Form1 : Form
    {
        private Button miBoton;
        private TextBox miTextBox;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            miBoton = new Button();
            miBoton.Size = new Size(70, 30);
            miBoton.Location = new Point(30, 30);
            miBoton.Text = "Haz clic";
            miBoton.Click += new EventHandler(MiBotonClick);

            miTextBox = new TextBox();
            miTextBox.Size = new Size(200, 30);
            miTextBox.Location = new Point(30, 70);

            Controls.Add(miBoton);
            Controls.Add(miTextBox);
        }

        //private void MiBotonClick(object sender, EventArgs e)
        {
            miTextBox.Text = "Has hecho clic en el botón!";
        }
    }
}
