using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_lab_8
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

















































































































































/*
var save = new SaveFileDialog();
save.Filter = "Jpg(*.jpg)|*.jpg|Png|*.png";
if (save.ShowDialog() == DialogResult.OK)
{
    Bitmap btm = bm.Clone(new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height), bm.PixelFormat);
    btm.Save(save.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
}
*/