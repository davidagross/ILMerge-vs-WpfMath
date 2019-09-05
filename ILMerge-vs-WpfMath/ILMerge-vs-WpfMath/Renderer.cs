using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WpfMath;

namespace ILMerge_vs_WpfMath
{
    public partial class Renderer : Form
    {
        // FIELDS **************************************************************
        /// <summary>
        /// Equation in LaTeX format
        /// </summary>
        private const string eqnLaTeX = @"\frac{8}{\pi}\text{atanh}\left(\tan\frac{\pi}{8}\right)";

        // METHODS *************************************************************
        /// <summary>
        /// Form constructor
        /// </summary>
        public Renderer()
        {
            InitializeComponent();

            try
            {
                DisplayEquation();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "There was an error:" + ex.ToString(), 
                    "Error", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
        }

        private void DisplayEquation()
        {
            var parser = new TexFormulaParser();
            var formula = parser.Parse(eqnLaTeX);
            var pngBytes = formula.RenderToPng(15.0, 0.0, 0.0, "Times New Roman");

            pictureBoxEquation.Image = ByteToImage(pngBytes);
        }

        /// <summary>
        /// Convert a byte array to a bitmap image
        /// </summary>
        /// <param name="blob"></param>
        /// <returns></returns>
        public static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }
    }
}
