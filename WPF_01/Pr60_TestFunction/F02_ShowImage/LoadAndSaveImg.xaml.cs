using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace Pr60_TestFunction.F02_ShowImage
{
    /// <summary>
    /// Interaction logic for LoadAndSaveImg.xaml
    /// </summary>
    public partial class LoadAndSaveImg : Page
    {
        string path = @"D:\Temp\CustomeTheme\";
        string newpath;
        
        public LoadAndSaveImg()
        {
            InitializeComponent();

            Button btn01 = new Button
            {
                FontSize = 20,
                FontFamily = new FontFamily("Times New Roman"),
                Margin = new Thickness(10),
                Content="Btn01",
                HorizontalAlignment=HorizontalAlignment.Center,
                VerticalAlignment=VerticalAlignment.Center
            };
            mainGrid.Children.Add(btn01);

            btn01.Click += OnBtnClicked;


            
        }

        private void OnBtnClicked(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.InitialDirectory = @"D:\WSpace\ImgFile\Natural";
            dlg.Filter = "BMP file|*.BMP|JPG file|*.JPG|PNG File|*.PNG|JIF File|*.gif|All File|*.*";
            dlg.FilterIndex = 5;
            bool? res = dlg.ShowDialog();

            if(res==true)
            {
                string filename = dlg.FileName;
                t01.Text = filename;

                BitmapImage bitmapImage = new BitmapImage(new Uri(filename));
                imgSave.Source = bitmapImage;

                //SaveImage(filename);
                SaveImage02(filename);
            }
        }

        private void SaveImage(string filename)
        {
            if(!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            string newImg = path + System.IO.Path.GetFileName(filename);
            var imageEncode = new PngBitmapEncoder();
            imageEncode.Frames.Add(BitmapFrame.Create((BitmapImage)imgSave.Source));
            FileStream fileStream = new FileStream(newImg, FileMode.Create);
            imageEncode.Save(fileStream);
            fileStream.Close();

            newpath = newImg;
        }


        private void SaveImage02(string filename)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            string newImg = path + System.IO.Path.GetFileName(filename);
            File.Copy(filename, newImg);
            
        }


        private void OnDeleteBtn_clicked(object sender, RoutedEventArgs e)
        {
            if(File.Exists(newpath))
            {
                File.Delete(newpath);
            }
        }

    }
}
