using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Xsl;

namespace Transformation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private XslCompiledTransform transformer;

        private void transformbtn_Click(object sender, EventArgs e)
        {
            try
            {
                transformer.Transform("nutrition.xml", "nutrition.html");

                transformTxtBox.Text = File.ReadAllText("nutrition.html");
            }
            catch(FileNotFoundException)
            {
                MessageBox.Show("XML File does not exist");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

                transformer = new XslCompiledTransform();

            try
            {
                transformer.Load("nutrition.xslt");
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("XSL File does not exist");
                Application.Exit();
            }

        }
    }
}
