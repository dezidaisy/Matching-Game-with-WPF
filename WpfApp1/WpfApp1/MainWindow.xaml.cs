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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Image> img = new List<Image>();
        public List<Button> btn = new List<Button>();
        public List<Button> btn11 = new List<Button>();
        List<Image> img21 = new List<Image>();
        List<Image> imgopen = new List<Image>();
        List<Image> img31 = new List<Image>();
        List<string> imglist2 = new List<string>();
        static int imagecount2 = 0;
        public List<string> x = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
            initializeimages();

        }


            public void initializeimages()
        {
            Random rnd = new Random();
            int r = 0;
            Object img1 = LayoutRoot.FindName("img1");
            img.Add((Image)img1);
            img31.Add((Image)img1);
            Object img2 = LayoutRoot.FindName("img2");
            img.Add((Image)img2);
            img31.Add((Image)img2);
            Object img3 = LayoutRoot.FindName("img3");
            img.Add((Image)img3);
            img31.Add((Image)img3);
            Object img4 = LayoutRoot.FindName("img4");
            img.Add((Image)img4);
            img31.Add((Image)img4);

            int y = 2;
            while (y>0)
            {
                r = rnd.Next(5)+1;
                x.Add( "Images/f" + r.ToString() + ".jpg");
                imglist2.Add(r.ToString());
                y--;

            }
            y = 2;
            while (y > 0)
            {
                r = rnd.Next(imglist2.Count);
                x.Add("Images/f" + imglist2[r] + ".jpg");
                imglist2.Remove(imglist2[r]);
                y--;

            }
            BitmapImage bi3 = new BitmapImage();
            bi3.BeginInit();
            for (int i = 0;i< img.Count; i++) {
                
                bi3.UriSource = new Uri("Images/f0.jpg", UriKind.RelativeOrAbsolute);
                img[i].Source = bi3;
                img[i].Stretch = Stretch.Fill;
                }
            bi3.EndInit();
        }

        public void btnclick1(object sender, RoutedEventArgs e)
        {
            BitmapImage bi3 = new BitmapImage();
            bi3.BeginInit();
            bi3.UriSource = new Uri(x[0], UriKind.RelativeOrAbsolute);
            bi3.EndInit();
            img[0].Stretch = Stretch.Fill;
            img[0].Source = bi3;

            if (!(img21.Exists(i => i == img[0])) && !(imgopen.Exists(i => i == img[0])))
            {
                img21.Add(img[0]);
                imgopen.Add(img[0]);
            }

            if (imgopen.Count >= 2)
            {
                checkimage();
            }
        }
        public void btnclick2(object sender, RoutedEventArgs e)
        {
                BitmapImage bi3 = new BitmapImage();
                bi3.BeginInit();
                bi3.UriSource = new Uri(x[1], UriKind.RelativeOrAbsolute);
                bi3.EndInit();
                img[1].Stretch = Stretch.Fill;
                img[1].Source = bi3;
            if (!(img21.Exists(i => i == img[1])) && !(imgopen.Exists(i => i == img[1])))
            {
                img21.Add(img[1]);
                imgopen.Add(img[1]);
            }
            if (imgopen.Count >= 2)
            {
                checkimage();
            }
        }

        public void btnclick3(object sender, RoutedEventArgs e)
        {
                BitmapImage bi3 = new BitmapImage();
                bi3.BeginInit();
                bi3.UriSource = new Uri(x[2], UriKind.RelativeOrAbsolute);
                bi3.EndInit();
                img[2].Stretch = Stretch.Fill;
                img[2].Source = bi3;

            if (!(img21.Exists(i => i == img[2])) && !(imgopen.Exists(i => i == img[2])))
            {
                img21.Add(img[2]);
                imgopen.Add(img[2]);
            }
            if (imgopen.Count >= 2)
            {
                checkimage();
            }
        }

        public void btnclick4(object sender, RoutedEventArgs e)
        {

                BitmapImage bi3 = new BitmapImage();
                bi3.BeginInit();
                bi3.UriSource = new Uri(x[3], UriKind.RelativeOrAbsolute);
                bi3.EndInit();
                img[3].Stretch = Stretch.Fill;
                img[3].Source = bi3;

            if (!(img21.Exists(i => i == img[3])) && !(imgopen.Exists(i => i == img[3])))
            {
                img21.Add(img[3]);
                imgopen.Add(img[3]);
            }
            if (imgopen.Count >= 2)
            {
                checkimage();
            }
        }
        public void imagetosuit()
        {
            BitmapImage bi3 = new BitmapImage();
            bi3.BeginInit();
            bi3.UriSource = new Uri("Images/f0.jpg", UriKind.RelativeOrAbsolute);
            for (int i = 0; i < img31.Count; i++)
            {        
                img31[i].Stretch = Stretch.Fill;
                img31[i].Source = bi3;
            }
            bi3.EndInit();
            if (imgopen.Count >=2)
            {
                imgopen.RemoveAt(1);
                imgopen.RemoveAt(0);
            }
        }
        public void checkimage()
        {
            if (!((img21.Count < 2) || (imgopen.Count < 2)))
            {
                
                if (x[img.IndexOf(img21[0])] == x[img.IndexOf(img21[1])])
                {


                    BitmapImage bi3 = new BitmapImage();
                    bi3.BeginInit();
                    bi3.UriSource = new Uri(x[img.IndexOf(img21[0])], UriKind.RelativeOrAbsolute);
                    img21[0].Source = bi3;
                    bi3.UriSource = new Uri(x[img.IndexOf(img21[1])], UriKind.RelativeOrAbsolute);
                    img21[1].Source = bi3;
                    bi3.EndInit();
                    img31.Remove(img21[0]);
                    img31.Remove(img21[1]);


                    imagecount2++;
                    if (imagecount2 > 1)
                    {
                        
                        MessageBoxButton btnMessageBox = MessageBoxButton.YesNoCancel;
                        MessageBoxButton btnMessageBox1 = MessageBoxButton.OK;
                        MessageBoxImage icnMessageBox = MessageBoxImage.Warning;
                        string sMessageBoxText = "New Game?";
                        string sCaption = "Matching Game";
                        MessageBox.Show("You Win!", sCaption, btnMessageBox1,  icnMessageBox);
                        MessageBoxResult rsltMessageBox = MessageBox.Show(sMessageBoxText, sCaption, btnMessageBox, icnMessageBox);

                        switch (rsltMessageBox)
                        {
                            case MessageBoxResult.Yes:
                                System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);
                                Application.Current.Shutdown();
                                break;

                            case MessageBoxResult.No:
                                Application.Current.Shutdown();
                                break;

                            case MessageBoxResult.Cancel:
                                Application.Current.Shutdown();
                                break;
                        }

                    }
                }
                else
                {
                    imagecount2 = 0;
                }

                img21.RemoveAt(1);
                img21.RemoveAt(0);
                imagetosuit();
            }

        }

        }
}
