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
using Emgu.Util;
using Emgu.CV.CvEnum;

namespace FaceRecognitionSystem
{
    public partial class MainForm : Form
    {
        //private Capture capture;
        //private bool captureInProgress;
        //private HaarCascade haar;

        Image<Bgr, Byte> currentFrame;
        Capture grabber;
        HaarCascade face;
        HaarCascade eye;
        MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_TRIPLEX, 0.5d, 0.5d);
        Image<Gray, byte> result, TrainedFace = null;
        Image<Gray, byte> gray = null;
        List<Image<Gray, byte>> trainingImages = new List<Image<Gray, byte>>();
        List<string> labels = new List<string>();
        //List<string> NamePersons = new List<string>();
        //int ContTrain, t, NumLabels;
        //string name, names = null;

        public MainForm()
        {
            InitializeComponent();
            face = new HaarCascade("haarcascade_frontalface_alt_tree.xml");
            eye  = new HaarCascade("haarcascade_eye.xml");
        }

        void FrameGrabber(object sender, EventArgs e)
        {
            currentFrame = grabber.QueryFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
            gray = currentFrame.Convert<Gray, Byte>();

            MCvAvgComp[][] faceDetected = gray.DetectHaarCascade(face, 1.1,
                                          1, Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
                                          new Size(20, 20));

            foreach (MCvAvgComp f in faceDetected[0])
            {
                //t = t + 1;
                result = currentFrame.Copy(f.rect).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                currentFrame.Draw(f.rect, new Bgr(Color.Green), 2);
            }
            //t = 0;

            ImageBoxFrameGrabber.Image = currentFrame;
        }
                
        private void MainForm_Load(object sender, EventArgs e)
        {
            grabber = new Capture();
            grabber.QueryFrame();
            Application.Idle += new EventHandler(FrameGrabber);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ContTrain = ContTrain + 1;


            gray = grabber.QueryGrayFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);


            MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(
                                            face, 1.1, 2,
                                            Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
                                            new Size(20, 20));


            foreach (MCvAvgComp f in facesDetected[0])
            {
                TrainedFace = currentFrame.Copy(f.rect).Convert<Gray, byte>();
                break;
            }

            TrainedFace = result.Resize(270, 250, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
            trainingImages.Add(TrainedFace);

            imageBox1.Image = TrainedFace;
            TrainedFace.Save(@"D:\ProjectDesign11\FaceRecognitionSystem\FaceRecognitionSystem\bin\Debug\Images\" + textBox1.Text + ".bmp" + "");

            MessageBox.Show("Image Captured Successfully!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void addRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCriminalRecord crecord = new AddCriminalRecord();
            crecord.ShowDialog();
        }

        private void camera1ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            LiveStream1 livestream1 = new LiveStream1();
            livestream1.ShowDialog();
        }

        private void wantedListsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RecordForm recordform = new RecordForm();
            recordform.ShowDialog();
        }
    }
}