using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Face
{
    public partial class Start : Form
    {
        MCvFont font = new MCvFont(Emgu.CV.CvEnum.FONT.CV_FONT_HERSHEY_TRIPLEX,0.6d,0.6d);
        HaarCascade faceDetected;
        Image<Bgr, Byte> Frame;
        Capture camera;

        Image<Gray, Byte> result;
        Image<Gray, Byte> TrainedFace = null;
        Image<Gray, Byte> grayFace = null;

        List<Image<Gray, Byte>> trainingImages = new List<Image<Gray, Byte>>();
        List<string> labels = new List<string>();
        List<string> Users = new List<string>();

        int Count, numLabels, t;
        string name, names = null;

        private void Register_Click(object sender, EventArgs e)
        {           
            camera = new Capture();
            camera.QueryFrame();
            cameraBox.Visible = true;
            Application.Idle += new EventHandler(FrameProcedure2);
        }

        public Start()
        {
            InitializeComponent();
            faceDetected = new HaarCascade("haarcascade_frontalface_default.xml");

            try
            {
                var Labelsinf = File.ReadAllText(Application.StartupPath + "/Faces/faces.txt");
                var Labels = Labelsinf.Split(',');

                if ((Labels[0]) == "")
                {
                    numLabels = 0;
                }
                else
                {
                    numLabels = Convert.ToInt32(Labels[0]);
                }

                Count = numLabels;
                var FacesLoad = "";

                for(int i = 0; i < numLabels + 1; i++)
                {
                    FacesLoad = "face" + i + ".bmp";
                    var image = new Image<Gray, byte>((Application.StartupPath + "/Faces/faces.txt"));
                    trainingImages.Add(image);
                    labels.Add(Labels[i]);


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Login_Click(object sender, EventArgs e)
        {
            
            camera = new Capture();
            camera.QueryFrame();
            cameraBox.Visible = true;
            Application.Idle += new EventHandler(FrameProcedure);
        }

        private void FrameProcedure(object sender, EventArgs e)
        {
            Users.Add("");
            Frame = camera.QueryFrame().Resize(320,240,Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
            grayFace = Frame.Convert<Gray, Byte>();
            var facesDetectedNow = grayFace.DetectHaarCascade(faceDetected,1.2,10,Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,new Size(20,20));

            foreach(var f in facesDetectedNow[0])
            {
                result = Frame.Copy(f.rect).Convert<Gray, Byte>().Resize(100,100,Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                Frame.Draw(f.rect,new Bgr(Color.Green),3);

                if(trainingImages.ToArray().Length != 0)
                {
                    var termCriterias = new MCvTermCriteria(Count, 0.001);
                    EigenObjectRecognizer recognizer = new EigenObjectRecognizer(trainingImages.ToArray(), labels.ToArray(), 1500, ref termCriterias);
                    name = recognizer.Recognize(result);
                    Frame.Draw(name, ref font, new Point(f.rect.X - 2, f.rect.Y - 2), new Bgr(Color.Red));                    
                }
             
                Users.Add("");
            }

            cameraBox.Image = Frame;
            names = "";
            Users.Clear();
            cameraBox.Visible = false;           
        }

        private void FrameProcedure2(object sender, EventArgs e)
        {
            Users.Add("");
            Frame = camera.QueryFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
            grayFace = Frame.Convert<Gray, Byte>();
            var facesDetectedNow = grayFace.DetectHaarCascade(faceDetected, 1.2, 10, Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(20, 20));

            foreach (var f in facesDetectedNow[0])
            {
                result = Frame.Copy(f.rect).Convert<Gray, Byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                Frame.Draw(f.rect, new Bgr(Color.Green), 3);
                if (trainingImages.ToArray().Length != 0)
                {
                    var termCriterias = new MCvTermCriteria(Count, 0.001);
                    EigenObjectRecognizer recognizer = new EigenObjectRecognizer(trainingImages.ToArray(), labels.ToArray(), 1500, ref termCriterias);
                    name = recognizer.Recognize(result);
                    Frame.Draw(name, ref font, new Point(f.rect.X - 2, f.rect.Y - 2), new Bgr(Color.Red));
                }

                Users.Add("");
            }
            cameraBox.Image = Frame;
            names = "";
            Users.Clear();
            cameraBox.Visible = false;            
        }
    }
}
