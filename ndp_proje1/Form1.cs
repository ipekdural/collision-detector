/****************************************************************************
** SAKARYA �N�VERS�TES�
** B�LG�SAYAR VE B�L���M B�L�MLER� FAK�LTES�
** B�LG�SAYAR M�HEND�SL��� B�L�M�
** PROGRAMLAMAYA G�R��� DERS�
**
** �DEV NUMARASI�...: 1
** ��RENC� ADI...............: IPEK DURAL
** ��RENC� NUMARASI.: G211210026
** DERS GRUBU����:2C
YOUTUBE L�NK݅ �:
****************************************************************************/
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ndp_proje1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }



        private void Form1_Load(object sender, EventArgs e)
        {

            string[] items = new string[] { "Point-Rectangle", "Point-Circle", "Rectangle-Rectangle", "Rectangle-Circle", "Circle-Circle", "Point-Sphere", "Point-Rectangular Prism", "Point-Cylinder", "Cylinder-Cylinder", "Sphere-Sphere", "Sphere-Cylinder", "Surface-Sphere", "Sphere-Rectangular Prism", "Rectangular Prism-Rectangular Prism" };
            comboBox1.Items.AddRange(items);


        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Point-Rectangle")
            {
                nokta_dortgen nokta_Dortgen = new nokta_dortgen();
                nokta_Dortgen.Show();
                this.Hide();

            }
            if (comboBox1.Text == "Point-Circle")
            {
                nokta_cember nokta_Cember = new nokta_cember();
                nokta_Cember.Show();
                this.Hide();

            }
            if (comboBox1.Text == "Rectangle-Rectangle")
            {
                dikdortgen_dikdortgen dikdortgen_Dikdortgen = new dikdortgen_dikdortgen();
                dikdortgen_Dikdortgen.Show();
                this.Hide();
            }
            if (comboBox1.Text == "Rectangle-Circle")
            {
                dikdortgen_cember dikdortgen_Cember = new dikdortgen_cember();
                dikdortgen_Cember.Show();
                this.Hide();
            }
            if (comboBox1.Text == "Circle-Circle")
            {
                cember_cember cember_Cember = new cember_cember();
                cember_Cember.Show();
                this.Hide();

            }
            if (comboBox1.Text == "Point-Sphere")
            {
                nokta_kure nokta_Kure= new nokta_kure();
                nokta_Kure.Show();
                this.Hide();
            }
            if(comboBox1.Text== "Point-Rectangular Prism")
            {
                nokta_dikdortgenler_prizmasi nokta_Dikdortgenler_Prizmasi = new nokta_dikdortgenler_prizmasi();
                nokta_Dikdortgenler_Prizmasi.Show();
                this.Hide();
            }
            if((comboBox1.Text == "Point-Cylinder"))
            {
                nokta_silindir nokta_Silindir = new nokta_silindir();
                nokta_Silindir.Show();
                this.Hide();   
            }
            if(comboBox1.Text== "Cylinder-Cylinder")
            {
               silindir_silindir silindir_Silindir=new silindir_silindir();
                silindir_Silindir.Show();
                this.Hide();
            }
            if(comboBox1.Text== "Sphere-Sphere")
            {
                kure_kure kure_Kure = new kure_kure();
                kure_Kure.Show();
                this.Hide();
            }
            if(comboBox1.Text== "Sphere-Cylinder")
            {
                kure_silindir kure_Silindir = new kure_silindir();
                kure_Silindir.Show();
                this.Hide();
            }
            if(comboBox1.Text== "Surface-Sphere")
            {
                yuzey_kure yuzey_Kure = new yuzey_kure();
                yuzey_Kure.Show();
                this.Hide();
            }
            if(comboBox1.Text== "Sphere-Rectangular Prism")
            {
                kure_dikdortgenler_prizmasi kure_Dikdortgenler_Prizmasi = new kure_dikdortgenler_prizmasi();
                kure_Dikdortgenler_Prizmasi.Show();
                this.Hide();
            }
            if (comboBox1.Text== "Rectangular Prism-Rectangular Prism")
            {
                dikdortgenler_prizmas�2 dikdortgenler_Prizmas�2 = new dikdortgenler_prizmas�2();
                dikdortgenler_Prizmas�2.Show();
                this.Hide();
            }
        }


    }
}
