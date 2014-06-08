using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace checkers_online   {
    public partial class Splash_screen : Form   {
        public Splash_screen()  {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)    {
            Splash_screen.ActiveForm.Opacity += 0.05;
            loadBar.Increment(1);
            if (loadBar.Value % 2 == 0) loadLabel.Text = loadBar.Value.ToString();
            if (loadBar.Value == 100)   {
                timer1.Stop();
                loadLabel.Text = "Готово!";
            } 
        }
    }
}
