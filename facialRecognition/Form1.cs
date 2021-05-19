using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Face;
using Emgu.CV.CvEnum;
using Microsoft.Diagnostics.Tracing.StackSources;

namespace facialRecognition
{
    public partial class Form1 : Form
    {
        #region variables
        private ICapture videoCapture = null;

        #endregion
        public Form1()
        {
            InitializeComponent();
        }

        
        private void btnCapture_Click(object sender, EventArgs e)
        {
            videoCapture = new VideoCapture();
            videoCapture.ImageGrabbed += ProcessFrame;
            videoCapture.Start();

        }

    }
}
    
    

