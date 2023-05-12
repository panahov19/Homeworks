using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace text_Document
{

    public partial class MainWindow : Window
    {

        public class textdoc :  ICloneable
        {
            public object Clone()
            {
                return new textdoc();
            }
        }

        public textdoc t = new();

        public string doc_name_temp = "";
        private string? dirParameter;

        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void create_btn_Click(object sender, RoutedEventArgs e)
        {
            if (doc_name.Text!="")
            {
                doc_name_temp = doc_name.Text;

                if (doc_name.Text != null)
                {
                    docs_list.Items.Add(doc_name.Text);

                }
                filename.Content = doc_name_temp;
                doc_name.Text = "";
                doc_name.IsEnabled = false;
                save_btn.IsEnabled = true;
                create_btn.IsEnabled = false;
                doc_text.IsEnabled = true;
            }
        }

        private void save_btn_Click(object sender, RoutedEventArgs e)
        {
            dirParameter = $@"C:\Users\Mamed\Desktop\{doc_name_temp}.txt";

            TextRange doc = new TextRange(doc_text.Document.ContentStart, doc_text.Document.ContentEnd);

            try
            {
                FileStream fParameter = new FileStream(dirParameter, FileMode.Truncate, FileAccess.Write);
                StreamWriter m_WriterParameter = new StreamWriter(fParameter);
                m_WriterParameter.BaseStream.Seek(0, SeekOrigin.End);
                m_WriterParameter.Write(doc.Text);
                m_WriterParameter.Flush();
                m_WriterParameter.Close();
            }

            catch
            {
                FileStream fParameter = new FileStream(dirParameter, FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter m_WriterParameter = new StreamWriter(fParameter);
                m_WriterParameter.BaseStream.Seek(0, SeekOrigin.End);
                m_WriterParameter.Write(doc.Text);
                m_WriterParameter.Flush();
                m_WriterParameter.Close();
            }

            filename.Content = "";
            doc_text.Document.Blocks.Clear();
            doc_text.IsEnabled = false;
            doc_name.IsEnabled = true;
            create_btn.IsEnabled = true;
        }

        private void edit_btn_Click(object sender, RoutedEventArgs e)
        {
           if (docs_list.SelectedItem!=null)
            {
                save_btn.IsEnabled = true;
                filename.Content = docs_list.SelectedItem;
                doc_text.Document.Blocks.Clear();
                doc_text.IsEnabled = true;
                doc_name.IsEnabled = false;
                create_btn.IsEnabled = false;

                dirParameter = $@"C:\Users\Mamed\Desktop\{docs_list.SelectedItem}.txt";

                FileStream frParameter = new FileStream(dirParameter, FileMode.Open, FileAccess.Read);
                StreamReader m_ReaderParameter = new StreamReader(frParameter);

                doc_text.Document.Blocks.Add(new Paragraph(new Run(m_ReaderParameter.ReadToEnd())));
                m_ReaderParameter.Close();
                frParameter.Close();
            }
        }

        private void remove_btn_Click(object sender, RoutedEventArgs e)
        {
            if(docs_list.SelectedItem != null)
            {
                save_btn.IsEnabled = false;
                doc_name.IsEnabled=true;
                create_btn.IsEnabled=true;
               filename.Content = "";
               doc_text.Document.Blocks.Clear();
               dirParameter = $@"C:\Users\Mamed\Desktop\{docs_list.SelectedItem}.txt";
               File.Delete(dirParameter);
               docs_list.Items.Remove(docs_list.SelectedItem);
            }
           
        }
    }
}
