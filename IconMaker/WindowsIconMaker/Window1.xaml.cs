using Microsoft.Win32;
using System;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace WindowsIconMaker
{
    public partial class Window1
    {
        private readonly double dpiX;
        private readonly double dpiY;
        private string filePath;

        private readonly IconDataSource dataSource;

        public Window1()
        {
            InitializeComponent();

            dataSource = new IconDataSource();
            iconList.ItemsSource = dataSource.Icons;

            dpiY = dpiY = 96;
        }

        #region OpenImage

        private void Open_Click(object sender, RoutedEventArgs e)
        {
            const string openFilter = "Image Files (*.png, *.jpg)|*.png;*.jpg|All files (*.*)|*.*";
            var dlg = new OpenFileDialog { Filter = openFilter };
            var result = dlg.ShowDialog();
            if (result != null && result.Value)
            {
                filePath = dlg.FileName;
                ShowImage(dlg.FileName);
            }
        }

        #endregion OpenImage

        #region ShowImage

        private void ShowImage(string filename)
        {
            var fileName = filename;
            var imageSource = new BitmapImage();
            imageSource.BeginInit();
            imageSource.UriSource = new Uri(fileName);
            imageSource.EndInit();

            grayImage.Source = imageSource;
            grayImage.Width = 300;
            grayImage.Height = 300;
        }

        #endregion ShowImage

        #region SaveIcons

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (filePath != null)
            {
                var rect = grayImage;
                rect.Stretch = Stretch.Uniform;
                rect.Source = new BitmapImage(new Uri(filePath));

                var directory = Path.GetDirectoryName(filePath);
                foreach (var iconInfo in dataSource.Icons)
                {
                    var path = Path.Combine(directory, "icon output");
                    Directory.CreateDirectory(path);
                    path = Path.Combine(path, iconInfo.FileName);
                    EncodeAndSave(rect, iconInfo.Width, iconInfo.Height, path);
                }

                rect.Width = rect.Height = 300;

                MessageBox.Show("生成成功");
            }
            else
            {
                MessageBox.Show("请先选择图片");
            }
        }

        private void EncodeAndSave(Image icon, double width, double height, string filePath)
        {
            icon.Width = width;
            icon.Height = height;

            var rtb = new RenderTargetBitmap((int)icon.Width, (int)icon.Height, dpiX, dpiY, PixelFormats.Pbgra32);

            var dv = new DrawingVisual();
            using (var dc = dv.RenderOpen())
            {
                var vb = new VisualBrush(icon) { Stretch = icon.Stretch };
                dc.DrawRectangle(vb, null, new Rect(new Point(), new Size((int)icon.Width, (int)icon.Height)));
            }
            rtb.Render(dv);
            var bmf = BitmapFrame.Create(rtb);
            bmf.Freeze();
            var stream = new FileStream(filePath, FileMode.Create);

            var encoder = new PngBitmapEncoder();
            encoder.Frames.Add(bmf);
            encoder.Save(stream);
            stream.Close();
        }

        #endregion SaveIcons

        private void addButton_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tbName.Text)) return;

                if (dataSource.Icons.Any(i => i.FileName.Equals(tbName.Text)))
                {
                    MessageBox.Show("文件已经存在");
                    return;
                }

                var iconInfo = new IconInfo
                {
                    Width = Convert.ToDouble(tbWidth.Text),
                    Height = Convert.ToDouble(tbWidth.Text),
                    FileName = tbName.Text
                };

                dataSource.Icons.Add(iconInfo);
            }
            catch (Exception)
            {
                MessageBox.Show("添加失败");
            }
        }
    }
}