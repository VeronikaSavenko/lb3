using System;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text.RegularExpressions;
using System.Windows.Forms;
namespace lb3._2
{
    public static class CurrentDirectory1
    {
        static Regex regexExtForImage = new Regex("^((.bmp)|(.gif)|(.tiff?)|(.jpe?g)|(.png))$", RegexOptions.IgnoreCase);

        public static void CurrentFiles(string path, string[] data)
        {
            foreach (string fileName in data)
            {
                try
                {
                    string ext = Path.GetExtension(fileName);
                    string newName = Path.ChangeExtension(fileName, null);
                    newName += "-mirrored.gif";
                    if (regexExtForImage.IsMatch(ext))
                    {
                        MirrorImage(newName, fileName);
                        Console.WriteLine($" Вiдзеркалення картики {fileName} пройшло успiшно");
                    }
                    else { Console.WriteLine(fileName + " не є картинкою"); }
                }
                catch (Exception)
                {
                    MessageBox.Show($"Помилка при завантаженні зображення\n{fileName}\n", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public static void MirrorImage(string name, string fileName)
        {
            Bitmap image = new Bitmap(fileName);
            image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            image.Save(name, ImageFormat.Gif);
        }
    }
}
