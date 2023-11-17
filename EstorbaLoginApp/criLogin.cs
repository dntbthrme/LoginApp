using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FaceRecognition;

namespace EstorbaLoginApp
{
    public partial class criLogin : Form
    {
        FaceRec facerec = new FaceRec();

        public criLogin()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            criLogin log = new criLogin();
            log.Show();
        }

        private void btncam_Click(object sender, EventArgs e)
        {
            facerec.openCamera(cameraBox, capturedBox);
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            facerec.Save_IMAGE(userTxtbox.Text.ToUpper());
            MessageBox.Show("SAVE", "SAVED!");
        }

        private void btndetect_Click(object sender, EventArgs e)
        {
            facerec.isTrained = true;
        }
    }
}
