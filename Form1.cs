using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Media;

namespace Notas
{
    public partial class Notas : Form
    {

        System.Timers.Timer contador; System.Timers.Timer contador2; System.Timers.Timer contador3; System.Timers.Timer contador4; System.Timers.Timer contador5; System.Timers.Timer contador6; System.Timers.Timer contador7; System.Timers.Timer contador8; System.Timers.Timer contador9; System.Timers.Timer contador10; System.Timers.Timer contador11; System.Timers.Timer contador12; System.Timers.Timer contador13; System.Timers.Timer contador14; System.Timers.Timer contador15; System.Timers.Timer contador16; System.Timers.Timer contador17;
        System.Timers.Timer contador18; System.Timers.Timer contador19; System.Timers.Timer contador20; System.Timers.Timer contador21; System.Timers.Timer contador22; System.Timers.Timer contador23; System.Timers.Timer contador24; System.Timers.Timer contador25; System.Timers.Timer contador26; System.Timers.Timer contador27; System.Timers.Timer contador28; System.Timers.Timer contador29; System.Timers.Timer contador30; System.Timers.Timer contador31; System.Timers.Timer contador32; System.Timers.Timer contador33; System.Timers.Timer contador34;
   //      bool verificaverde1; bool verificaverde2; bool verificaverde3; bool verificaverde4; bool verificaverde5; bool verificaverde6; bool verificaverde7; bool verificaverde8; bool verificaverde9; bool verificaverde10; bool verificaverde11; bool verificaverde12; bool verificaverde13; bool verificaverde14; bool verificaverde15; bool verificaverde16; bool verificaverde17; bool verificaverde18; bool verificaverde19; bool verificaverde20; bool verificaverde21; bool verificaverde22; bool verificaverde23; bool verificaverde24; bool verificaverde25; 
     //   bool verificaverde26; bool verificaverde27; bool verificaverde28; bool verificaverde29; bool verificaverde30; bool verificaverde31; bool verificaverde32; bool verificaverde33; bool verificaverde34;


        public Notas()
        {
            InitializeComponent();
        }


        public void MarcaCheckBox(TextBox Nota, Button buttonExcluir, CheckBox checknota, Button buttonadd, Button buttonmarcar, DateTimePicker timer, System.Timers.Timer contador)
        {           


            if (checknota.CheckState == CheckState.Checked)
            {
                
                buttonmarcar.Visible = false;
                timer.Visible = false;
                contador.Stop();

                Nota.BackColor = Color.SpringGreen;

                MessageBox.Show("Tarefa Concluida!!!", "Parabens", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult confirmar = MessageBox.Show("Deseja excluir a tarefa?", "Escolha", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmar.ToString().ToUpper() == "YES")
                {
                    Nota.Text = "";
                    Nota.Visible = false;
                    Nota.BackColor = Color.Orange;
                    buttonExcluir.Visible = false;
                    checknota.Visible = false;
                    checknota.CheckState = CheckState.Unchecked;
                    buttonadd.Visible = true;


                }
            }

        }

        public void AcoesButtonAdd(TextBox nota, Button buttonExcluir, CheckBox checknota, Button buttonadd, Button buttonmarcar, DateTimePicker timer)
        {
            nota.Visible = true;
            buttonExcluir.Visible = true;
            checknota.Visible = true;
            nota.BackColor = Color.Orange;
            buttonadd.Visible = false;
            buttonmarcar.Visible = true;
            timer.Visible = true;

        }

        public void AcoesButtonRemove(TextBox nota, Button buttonExcluir, CheckBox checknota, Button buttonadd, Button buttonmarcar, DateTimePicker timer)
        {
            nota.Text = "";
            nota.Visible = false;
            buttonExcluir.Visible = false;
            checknota.CheckState = CheckState.Unchecked;
            checknota.Visible = false;
            buttonadd.Visible = true;
            buttonmarcar.Visible = false;
            timer.Visible = false;
            timer.Enabled = true;
            buttonmarcar.Enabled = true;
        }

        public void VerificaVazio()
        {

            if (Nota0.Text != "")
            {
                Timer1.Visible = true;
                btnMarcar.Visible = true;
                button1.Visible = false;
                Nota0.Visible = true;
                buttonExcluirStart.Visible = true;
                checknota1.Visible = true;

            }

            if (Nota2.Text != "")
            {
                Timer2.Visible = true;
                btnMarcar2.Visible = true;
                button2.Visible = false;
                Nota2.Visible = true;
                buttonExcluir2.Visible = true;
                checknota2.Visible = true;
            }
            if (Nota3.Text != "")
            {
                Timer3.Visible = true;
                btnMarcar3.Visible = true;
                button3.Visible = false;
                Nota3.Visible = true;
                buttonExcluir3.Visible = true;
                checknota3.Visible = true;
            }
            if (Nota4.Text != "")
            {
                Timer4.Visible = true;
                btnMarcar4.Visible = true;
                button4.Visible = false;
                Nota4.Visible = true;
                buttonExcluir4.Visible = true;
                checknota4.Visible = true;
            }
            if (Nota5.Text != "")
            {
                Timer5.Visible = true;
                btnMarcar5.Visible = true;
                button5.Visible = false;
                Nota5.Visible = true;
                buttonExcluir5.Visible = true;
                checknota5.Visible = true;
            }
            if (Nota6.Text != "")
            {
                Timer6.Visible = true;
                btnMarcar6.Visible = true;
                button6.Visible = false;
                Nota6.Visible = true;
                buttonExcluir6.Visible = true;
                checknota6.Visible = true;
            }
            if (Nota7.Text != "")
            {
                Timer7.Visible = true;
                btnMarcar7.Visible = true;
                button7.Visible = false;
                Nota7.Visible = true;
                buttonExcluir7.Visible = true;
                checknota7.Visible = true;
            }
            if (Nota8.Text != "")
            {
                Timer8.Visible = true;
                btnMarcar8.Visible = true;
                button8.Visible = false;
                Nota8.Visible = true;
                buttonExcluir8.Visible = true;
                checknota8.Visible = true;
            }
            if (Nota9.Text != "")
            {
                Timer9.Visible = true;
                btnMarcar9.Visible = true;
                button9.Visible = false;
                Nota9.Visible = true;
                buttonExcluir9.Visible = true;
                checknota9.Visible = true;
            }
            if (Nota10.Text != "")
            {
                Timer10.Visible = true;
                btnMarcar10.Visible = true;
                button10.Visible = false;
                Nota10.Visible = true;
                buttonExcluir10.Visible = true;
                checknota10.Visible = true;
            }
            if (Nota11.Text != "")
            {
                Timer11.Visible = true;
                btnMarcar11.Visible = true;
                button11.Visible = false;
                Nota11.Visible = true;
                buttonExcluir11.Visible = true;
                checknota11.Visible = true;
            }
            if (Nota12.Text != "")
            {
                Timer12.Visible = true;
                btnMarcar12.Visible = true;
                button12.Visible = false;
                Nota12.Visible = true;
                buttonExcluir12.Visible = true;
                checknota12.Visible = true;
            }
            if (Nota13.Text != "")
            {
                Timer13.Visible = true;
                btnMarcar13.Visible = true;
                button13.Visible = false;
                Nota13.Visible = true;
                buttonExcluir13.Visible = true;
                checknota13.Visible = true;
            }
            if (Nota14.Text != "")
            {
                Timer14.Visible = true;
                btnMarcar14.Visible = true;
                button14.Visible = false;
                Nota14.Visible = true;
                buttonExcluir14.Visible = true;
                checknota14.Visible = true;
            }
            if (Nota15.Text != "")
            {
                Timer15.Visible = true;
                btnMarcar15.Visible = true;
                button15.Visible = false;
                Nota15.Visible = true;
                buttonExcluir15.Visible = true;
                checknota15.Visible = true;
            }
            if (Nota16.Text != "")
            {
                Timer16.Visible = true;
                btnMarcar16.Visible = true;
                button16.Visible = false;
                Nota16.Visible = true;
                buttonExcluir16.Visible = true;
                checknota16.Visible = true;
            }
            if (Nota17.Text != "")
            {
                Timer17.Visible = true;
                btnMarcar17.Visible = true;
                button17.Visible = false;
                Nota17.Visible = true;
                buttonExcluir17.Visible = true;
                checknota17.Visible = true;
            }
            if (Nota18.Text != "")
            {
                Timer18.Visible = true;
                btnMarcar18.Visible = true;
                button18.Visible = false;
                Nota18.Visible = true;
                buttonExcluir18.Visible = true;
                checknota18.Visible = true;
            }
            if (Nota19.Text != "")
            {
                Timer19.Visible = true;
                btnMarcar19.Visible = true;
                button19.Visible = false;
                Nota19.Visible = true;
                buttonExcluir19.Visible = true;
                checknota19.Visible = true;
            }
            if (Nota20.Text != "")
            {
                Timer20.Visible = true;
                btnMarcar20.Visible = true;
                button20.Visible = false;
                Nota20.Visible = true;
                buttonExcluir20.Visible = true;
                checknota20.Visible = true;
            }
            if (Nota21.Text != "")
            {

                Timer21.Visible = true;
                btnMarcar21.Visible = true;
                button21.Visible = false;
                Nota21.Visible = true;
                buttonExcluir21.Visible = true;
                checknota21.Visible = true;
            }
            if (Nota22.Text != "")
            {

                Timer22.Visible = true;
                btnMarcar22.Visible = true;
                button22.Visible = false;
                Nota22.Visible = true;
                buttonExcluir22.Visible = true;
                checknota22.Visible = true;
            }
            if (Nota23.Text != "")
            {

                Timer23.Visible = true;
                btnMarcar23.Visible = true;
                button23.Visible = false;
                Nota23.Visible = true;
                buttonExcluir23.Visible = true;
                checknota23.Visible = true;
            }
            if (Nota24.Text != "")
            {

                Timer24.Visible = true;
                btnMarcar24.Visible = true;
                button24.Visible = false;
                Nota24.Visible = true;
                buttonExcluir24.Visible = true;
                checknota24.Visible = true;
            }
            if (Nota25.Text != "")
            {

                Timer25.Visible = true;
                btnMarcar25.Visible = true;
                button25.Visible = false;
                Nota25.Visible = true;
                buttonExcluir25.Visible = true;
                checknota25.Visible = true;
            }
            if (Nota26.Text != "")
            {

                Timer26.Visible = true;
                btnMarcar26.Visible = true;
                button26.Visible = false;
                Nota26.Visible = true;
                buttonExcluir26.Visible = true;
                checknota26.Visible = true;
            }
            if (Nota27.Text != "")
            {

                Timer27.Visible = true;
                btnMarcar27.Visible = true;
                button27.Visible = false;
                Nota27.Visible = true;
                buttonExcluir27.Visible = true;
                checknota27.Visible = true;
            }
            if (Nota28.Text != "")
            {

                Timer28.Visible = true;
                btnMarcar28.Visible = true;
                button28.Visible = false;
                Nota28.Visible = true;
                buttonExcluir28.Visible = true;
                checknota28.Visible = true;
            }
            if (Nota29.Text != "")
            {

                Timer29.Visible = true;
                btnMarcar29.Visible = true;
                button29.Visible = false;
                Nota29.Visible = true;
                buttonExcluir29.Visible = true;
                checknota29.Visible = true;
            }
            if (Nota30.Text != "")
            {

                Timer30.Visible = true;
                btnMarcar30.Visible = true;
                button30.Visible = false;
                Nota30.Visible = true;
                buttonExcluir30.Visible = true;
                checknota30.Visible = true;
            }
            if (Nota31.Text != "")
            {

                Timer31.Visible = true;
                btnMarcar31.Visible = true;
                button31.Visible = false;
                Nota31.Visible = true;
                buttonExcluir31.Visible = true;
                checknota31.Visible = true;
            }
            if (Nota32.Text != "")
            {

                Timer32.Visible = true;
                btnMarcar32.Visible = true;
                button32.Visible = false;
                Nota32.Visible = true;
                buttonExcluir32.Visible = true;
                checknota32.Visible = true;
            }
            if (Nota33.Text != "")
            {

                Timer33.Visible = true;
                btnMarcar33.Visible = true;
                button33.Visible = false;
                Nota33.Visible = true;
                buttonExcluir33.Visible = true;
                checknota33.Visible = true;
            }
            if (Nota34.Text != "")
            {
                Nota34.Visible = true;
                buttonExcluir34.Visible = true;
                checknota34.Visible = true;
            }
        }

     

        private void salva_texto() //SALVA O TEXTO NO TXT
        {
            StreamWriter fluxoTexto0;
            StreamWriter fluxoTexto2;
            StreamWriter fluxoTexto3;
            StreamWriter fluxoTexto4;
            StreamWriter fluxoTexto5;
            StreamWriter fluxoTexto6;
            StreamWriter fluxoTexto7;
            StreamWriter fluxoTexto8;
            StreamWriter fluxoTexto9;
            StreamWriter fluxoTexto10;
            StreamWriter fluxoTexto11;
            StreamWriter fluxoTexto12;
            StreamWriter fluxoTexto13;
            StreamWriter fluxoTexto14;
            StreamWriter fluxoTexto15;
            StreamWriter fluxoTexto16;
            StreamWriter fluxoTexto17;
            StreamWriter fluxoTexto18;
            StreamWriter fluxoTexto19;
            StreamWriter fluxoTexto20;
            StreamWriter fluxoTexto21;
            StreamWriter fluxoTexto22;
            StreamWriter fluxoTexto23;
            StreamWriter fluxoTexto24;
            StreamWriter fluxoTexto25;
            StreamWriter fluxoTexto26;
            StreamWriter fluxoTexto27;
            StreamWriter fluxoTexto28;
            StreamWriter fluxoTexto29;
            StreamWriter fluxoTexto30;
            StreamWriter fluxoTexto31;
            StreamWriter fluxoTexto32;
            StreamWriter fluxoTexto33;
            StreamWriter fluxoTexto34;



            string Arquivo0 = "Nota0.txt";
            string Arquivo2 = "Nota2.txt";
            string Arquivo3 = "Nota3.txt";
            string Arquivo4 = "Nota4.txt";
            string Arquivo5 = "Nota5.txt";
            string Arquivo6 = "Nota6.txt";
            string Arquivo7 = "Nota7.txt";
            string Arquivo8 = "Nota8.txt";
            string Arquivo9 = "Nota9.txt";
            string Arquivo10 = "Nota10.txt";
            string Arquivo11 = "Nota11.txt";
            string Arquivo12 = "Nota12.txt";
            string Arquivo13 = "Nota13.txt";
            string Arquivo14 = "Nota14.txt";
            string Arquivo15 = "Nota15.txt";
            string Arquivo16 = "Nota16.txt";
            string Arquivo17 = "Nota17.txt";
            string Arquivo18 = "Nota18.txt";
            string Arquivo19 = "Nota19.txt";
            string Arquivo20 = "Nota20.txt";
            string Arquivo21 = "Nota21.txt";
            string Arquivo22 = "Nota22.txt";
            string Arquivo23 = "Nota23.txt";
            string Arquivo24 = "Nota24.txt";
            string Arquivo25 = "Nota25.txt";
            string Arquivo26 = "Nota26.txt";
            string Arquivo27 = "Nota27.txt";
            string Arquivo28 = "Nota28.txt";
            string Arquivo29 = "Nota29.txt";
            string Arquivo30 = "Nota30.txt";
            string Arquivo31 = "Nota31.txt";
            string Arquivo32 = "Nota32.txt";
            string Arquivo33 = "Nota33.txt";
            string Arquivo34 = "Nota34.txt";





            if (Arquivo28 == "ARQUIVO INDALIDO")
            {
                MessageBox.Show("Arquivo Invalido", "Salvar Como", MessageBoxButtons.OK);
            }
            else
            {
                fluxoTexto0 = new StreamWriter(Arquivo0);
                fluxoTexto2 = new StreamWriter(Arquivo2);
                fluxoTexto3 = new StreamWriter(Arquivo3);
                fluxoTexto4 = new StreamWriter(Arquivo4);
                fluxoTexto5 = new StreamWriter(Arquivo5);
                fluxoTexto6 = new StreamWriter(Arquivo6);
                fluxoTexto7 = new StreamWriter(Arquivo7);
                fluxoTexto8 = new StreamWriter(Arquivo8);
                fluxoTexto9 = new StreamWriter(Arquivo9);
                fluxoTexto10 = new StreamWriter(Arquivo10);
                fluxoTexto11 = new StreamWriter(Arquivo11);
                fluxoTexto12 = new StreamWriter(Arquivo12);
                fluxoTexto13 = new StreamWriter(Arquivo13);
                fluxoTexto14 = new StreamWriter(Arquivo14);
                fluxoTexto15 = new StreamWriter(Arquivo15);
                fluxoTexto16 = new StreamWriter(Arquivo16);
                fluxoTexto17 = new StreamWriter(Arquivo17);
                fluxoTexto18 = new StreamWriter(Arquivo18);
                fluxoTexto19 = new StreamWriter(Arquivo19);
                fluxoTexto20 = new StreamWriter(Arquivo20);
                fluxoTexto21 = new StreamWriter(Arquivo21);
                fluxoTexto22 = new StreamWriter(Arquivo22);
                fluxoTexto23 = new StreamWriter(Arquivo23);
                fluxoTexto24 = new StreamWriter(Arquivo24);
                fluxoTexto25 = new StreamWriter(Arquivo25);
                fluxoTexto26 = new StreamWriter(Arquivo26);
                fluxoTexto27 = new StreamWriter(Arquivo27);
                fluxoTexto28 = new StreamWriter(Arquivo28);
                fluxoTexto29 = new StreamWriter(Arquivo29);
                fluxoTexto30 = new StreamWriter(Arquivo30);
                fluxoTexto31 = new StreamWriter(Arquivo31);
                fluxoTexto32 = new StreamWriter(Arquivo32);
                fluxoTexto33 = new StreamWriter(Arquivo33);
                fluxoTexto34 = new StreamWriter(Arquivo34);


                fluxoTexto0.Write(Nota0.Text);
                fluxoTexto2.Write(Nota2.Text);
                fluxoTexto3.Write(Nota3.Text);
                fluxoTexto4.Write(Nota4.Text);
                fluxoTexto5.Write(Nota5.Text);
                fluxoTexto6.Write(Nota6.Text);
                fluxoTexto7.Write(Nota7.Text);
                fluxoTexto8.Write(Nota8.Text);
                fluxoTexto9.Write(Nota9.Text);
                fluxoTexto10.Write(Nota10.Text);
                fluxoTexto11.Write(Nota11.Text);
                fluxoTexto12.Write(Nota12.Text);
                fluxoTexto13.Write(Nota13.Text);
                fluxoTexto14.Write(Nota14.Text);
                fluxoTexto15.Write(Nota15.Text);
                fluxoTexto16.Write(Nota16.Text);
                fluxoTexto17.Write(Nota17.Text);
                fluxoTexto18.Write(Nota18.Text);
                fluxoTexto19.Write(Nota19.Text);
                fluxoTexto20.Write(Nota20.Text);
                fluxoTexto21.Write(Nota21.Text);
                fluxoTexto22.Write(Nota22.Text);
                fluxoTexto23.Write(Nota23.Text);
                fluxoTexto24.Write(Nota24.Text);
                fluxoTexto25.Write(Nota25.Text);
                fluxoTexto26.Write(Nota26.Text);
                fluxoTexto27.Write(Nota27.Text);
                fluxoTexto28.Write(Nota28.Text);
                fluxoTexto29.Write(Nota29.Text);
                fluxoTexto30.Write(Nota30.Text);
                fluxoTexto31.Write(Nota31.Text);
                fluxoTexto32.Write(Nota32.Text);
                fluxoTexto33.Write(Nota33.Text);
                fluxoTexto34.Write(Nota34.Text);



                fluxoTexto0.Close();
                fluxoTexto2.Close();
                fluxoTexto3.Close();
                fluxoTexto4.Close();
                fluxoTexto5.Close();
                fluxoTexto6.Close();
                fluxoTexto7.Close();
                fluxoTexto8.Close();
                fluxoTexto9.Close();
                fluxoTexto10.Close();
                fluxoTexto11.Close();
                fluxoTexto12.Close();
                fluxoTexto13.Close();
                fluxoTexto14.Close();
                fluxoTexto15.Close();
                fluxoTexto16.Close();
                fluxoTexto17.Close();
                fluxoTexto18.Close();
                fluxoTexto19.Close();
                fluxoTexto20.Close();
                fluxoTexto21.Close();
                fluxoTexto22.Close();
                fluxoTexto23.Close();
                fluxoTexto24.Close();
                fluxoTexto25.Close();
                fluxoTexto26.Close();
                fluxoTexto27.Close();
                fluxoTexto28.Close();
                fluxoTexto29.Close();
                fluxoTexto30.Close();
                fluxoTexto31.Close();
                fluxoTexto32.Close();
                fluxoTexto33.Close();
                fluxoTexto34.Close();


            }
        }


        private void ler_texto_salvo() //LE O TEXTO JA SALVO PARA FAZER O RETORNO
        {
            StreamReader fluxoTexto0;
            StreamReader fluxoTexto2;
            StreamReader fluxoTexto3;
            StreamReader fluxoTexto4;
            StreamReader fluxoTexto5;
            StreamReader fluxoTexto6;
            StreamReader fluxoTexto7;
            StreamReader fluxoTexto8;
            StreamReader fluxoTexto9;
            StreamReader fluxoTexto10;
            StreamReader fluxoTexto11;
            StreamReader fluxoTexto12;
            StreamReader fluxoTexto13;
            StreamReader fluxoTexto14;
            StreamReader fluxoTexto15;
            StreamReader fluxoTexto16;
            StreamReader fluxoTexto17;
            StreamReader fluxoTexto18;
            StreamReader fluxoTexto19;
            StreamReader fluxoTexto20;
            StreamReader fluxoTexto21;
            StreamReader fluxoTexto22;
            StreamReader fluxoTexto23;
            StreamReader fluxoTexto24;
            StreamReader fluxoTexto25;
            StreamReader fluxoTexto26;
            StreamReader fluxoTexto27;
            StreamReader fluxoTexto28;
            StreamReader fluxoTexto29;
            StreamReader fluxoTexto30;
            StreamReader fluxoTexto31;
            StreamReader fluxoTexto32;
            StreamReader fluxoTexto33;
            StreamReader fluxoTexto34;


            string linhaTexto;

            if (File.Exists("Nota0.txt"))
            {
                fluxoTexto0 = new StreamReader("Nota0.txt");
                linhaTexto = fluxoTexto0.ReadLine();
                String Str_Leitura = "";


                while (linhaTexto != null)
                {
                    Str_Leitura += linhaTexto + Environment.NewLine;
                    linhaTexto = fluxoTexto0.ReadLine();
                }

                fluxoTexto0.Close();

                Nota0.Text = Str_Leitura;

            }

            if (File.Exists("Nota2.txt"))
            {
                fluxoTexto2 = new StreamReader("Nota2.txt");
                linhaTexto = fluxoTexto2.ReadLine();
                String Str_Leitura = "";


                while (linhaTexto != null)
                {
                    Str_Leitura += linhaTexto + Environment.NewLine;
                    linhaTexto = fluxoTexto2.ReadLine();
                }

                fluxoTexto2.Close();

                Nota2.Text = Str_Leitura;

            }


            if (File.Exists("Nota3.txt"))
            {
                fluxoTexto3 = new StreamReader("Nota3.txt");
                linhaTexto = fluxoTexto3.ReadLine();
                String Str_Leitura = "";


                while (linhaTexto != null)
                {
                    Str_Leitura += linhaTexto + Environment.NewLine;
                    linhaTexto = fluxoTexto3.ReadLine();
                }

                fluxoTexto3.Close();

                Nota3.Text = Str_Leitura;

            }

            if (File.Exists("Nota4.txt"))
            {
                fluxoTexto4 = new StreamReader("Nota4.txt");
                linhaTexto = fluxoTexto4.ReadLine();
                String Str_Leitura = "";


                while (linhaTexto != null)
                {
                    Str_Leitura += linhaTexto + Environment.NewLine;
                    linhaTexto = fluxoTexto4.ReadLine();
                }

                fluxoTexto4.Close();

                Nota4.Text = Str_Leitura;

            }

            if (File.Exists("Nota5.txt"))
            {
                fluxoTexto5 = new StreamReader("Nota5.txt");
                linhaTexto = fluxoTexto5.ReadLine();
                String Str_Leitura = "";


                while (linhaTexto != null)
                {
                    Str_Leitura += linhaTexto + Environment.NewLine;
                    linhaTexto = fluxoTexto5.ReadLine();
                }

                fluxoTexto5.Close();

                Nota5.Text = Str_Leitura;

            }

            if (File.Exists("Nota6.txt"))
            {
                fluxoTexto6 = new StreamReader("Nota6.txt");
                linhaTexto = fluxoTexto6.ReadLine();
                String Str_Leitura = "";


                while (linhaTexto != null)
                {
                    Str_Leitura += linhaTexto + Environment.NewLine;
                    linhaTexto = fluxoTexto6.ReadLine();
                }

                fluxoTexto6.Close();

                Nota6.Text = Str_Leitura;

            }

            if (File.Exists("Nota7.txt"))
            {
                fluxoTexto7 = new StreamReader("Nota7.txt");
                linhaTexto = fluxoTexto7.ReadLine();
                String Str_Leitura = "";


                while (linhaTexto != null)
                {
                    Str_Leitura += linhaTexto + Environment.NewLine;
                    linhaTexto = fluxoTexto7.ReadLine();
                }

                fluxoTexto7.Close();

                Nota7.Text = Str_Leitura;

            }

            if (File.Exists("Nota8.txt"))
            {
                fluxoTexto8 = new StreamReader("Nota8.txt");
                linhaTexto = fluxoTexto8.ReadLine();
                String Str_Leitura = "";


                while (linhaTexto != null)
                {
                    Str_Leitura += linhaTexto + Environment.NewLine;
                    linhaTexto = fluxoTexto8.ReadLine();
                }

                fluxoTexto8.Close();

                Nota8.Text = Str_Leitura;

            }

            if (File.Exists("Nota9.txt"))
            {
                fluxoTexto9 = new StreamReader("Nota9.txt");
                linhaTexto = fluxoTexto9.ReadLine();
                String Str_Leitura = "";


                while (linhaTexto != null)
                {
                    Str_Leitura += linhaTexto + Environment.NewLine;
                    linhaTexto = fluxoTexto9.ReadLine();
                }

                fluxoTexto9.Close();

                Nota9.Text = Str_Leitura;

            }

            if (File.Exists("Nota10.txt"))
            {
                fluxoTexto10 = new StreamReader("Nota10.txt");
                linhaTexto = fluxoTexto10.ReadLine();
                String Str_Leitura = "";


                while (linhaTexto != null)
                {
                    Str_Leitura += linhaTexto + Environment.NewLine;
                    linhaTexto = fluxoTexto10.ReadLine();
                }

                fluxoTexto10.Close();

                Nota10.Text = Str_Leitura;

            }

            if (File.Exists("Nota11.txt"))
            {
                fluxoTexto11 = new StreamReader("Nota11.txt");
                linhaTexto = fluxoTexto11.ReadLine();
                String Str_Leitura = "";


                while (linhaTexto != null)
                {
                    Str_Leitura += linhaTexto + Environment.NewLine;
                    linhaTexto = fluxoTexto11.ReadLine();
                }

                fluxoTexto11.Close();

                Nota11.Text = Str_Leitura;

            }

            if (File.Exists("Nota12.txt"))
            {
                fluxoTexto12 = new StreamReader("Nota12.txt");
                linhaTexto = fluxoTexto12.ReadLine();
                String Str_Leitura = "";


                while (linhaTexto != null)
                {
                    Str_Leitura += linhaTexto + Environment.NewLine;
                    linhaTexto = fluxoTexto12.ReadLine();
                }

                fluxoTexto12.Close();

                Nota12.Text = Str_Leitura;

            }

            if (File.Exists("Nota13.txt"))
            {
                fluxoTexto13 = new StreamReader("Nota13.txt");
                linhaTexto = fluxoTexto13.ReadLine();
                String Str_Leitura = "";


                while (linhaTexto != null)
                {
                    Str_Leitura += linhaTexto + Environment.NewLine;
                    linhaTexto = fluxoTexto13.ReadLine();
                }

                fluxoTexto13.Close();

                Nota13.Text = Str_Leitura;

            }

            if (File.Exists("Nota14.txt"))
            {
                fluxoTexto14 = new StreamReader("Nota14.txt");
                linhaTexto = fluxoTexto14.ReadLine();
                String Str_Leitura = "";


                while (linhaTexto != null)
                {
                    Str_Leitura += linhaTexto + Environment.NewLine;
                    linhaTexto = fluxoTexto14.ReadLine();
                }

                fluxoTexto14.Close();

                Nota14.Text = Str_Leitura;

            }

            if (File.Exists("Nota15.txt"))
            {
                fluxoTexto15 = new StreamReader("Nota15.txt");
                linhaTexto = fluxoTexto15.ReadLine();
                String Str_Leitura = "";


                while (linhaTexto != null)
                {
                    Str_Leitura += linhaTexto + Environment.NewLine;
                    linhaTexto = fluxoTexto15.ReadLine();
                }

                fluxoTexto15.Close();

                Nota15.Text = Str_Leitura;

            }

            if (File.Exists("Nota16.txt"))
            {
                fluxoTexto16 = new StreamReader("Nota16.txt");
                linhaTexto = fluxoTexto16.ReadLine();
                String Str_Leitura = "";


                while (linhaTexto != null)
                {
                    Str_Leitura += linhaTexto + Environment.NewLine;
                    linhaTexto = fluxoTexto16.ReadLine();
                }

                fluxoTexto16.Close();

                Nota16.Text = Str_Leitura;

            }

            if (File.Exists("Nota17.txt"))
            {
                fluxoTexto17 = new StreamReader("Nota17.txt");
                linhaTexto = fluxoTexto17.ReadLine();
                String Str_Leitura = "";


                while (linhaTexto != null)
                {
                    Str_Leitura += linhaTexto + Environment.NewLine;
                    linhaTexto = fluxoTexto17.ReadLine();
                }

                fluxoTexto17.Close();

                Nota17.Text = Str_Leitura;

            }

            if (File.Exists("Nota18.txt"))
            {
                fluxoTexto18 = new StreamReader("Nota18.txt");
                linhaTexto = fluxoTexto18.ReadLine();
                String Str_Leitura = "";


                while (linhaTexto != null)
                {
                    Str_Leitura += linhaTexto + Environment.NewLine;
                    linhaTexto = fluxoTexto18.ReadLine();
                }

                fluxoTexto18.Close();

                Nota18.Text = Str_Leitura;

            }

            if (File.Exists("Nota19.txt"))
            {
                fluxoTexto19 = new StreamReader("Nota19.txt");
                linhaTexto = fluxoTexto19.ReadLine();
                String Str_Leitura = "";


                while (linhaTexto != null)
                {
                    Str_Leitura += linhaTexto + Environment.NewLine;
                    linhaTexto = fluxoTexto19.ReadLine();
                }

                fluxoTexto19.Close();

                Nota19.Text = Str_Leitura;

            }

            if (File.Exists("Nota20.txt"))
            {
                fluxoTexto20 = new StreamReader("Nota20.txt");
                linhaTexto = fluxoTexto20.ReadLine();
                String Str_Leitura = "";


                while (linhaTexto != null)
                {
                    Str_Leitura += linhaTexto + Environment.NewLine;
                    linhaTexto = fluxoTexto20.ReadLine();
                }

                fluxoTexto20.Close();

                Nota20.Text = Str_Leitura;

            }


            if (File.Exists("Nota21.txt"))
            {
                fluxoTexto21 = new StreamReader("Nota21.txt");
                linhaTexto = fluxoTexto21.ReadLine();
                String Str_Leitura = "";


                while (linhaTexto != null)
                {
                    Str_Leitura += linhaTexto + Environment.NewLine;
                    linhaTexto = fluxoTexto21.ReadLine();
                }

                fluxoTexto21.Close();

                Nota21.Text = Str_Leitura;

            }

            if (File.Exists("Nota22.txt"))
            {
                fluxoTexto22 = new StreamReader("Nota22.txt");
                linhaTexto = fluxoTexto22.ReadLine();
                String Str_Leitura = "";


                while (linhaTexto != null)
                {
                    Str_Leitura += linhaTexto + Environment.NewLine;
                    linhaTexto = fluxoTexto22.ReadLine();
                }

                fluxoTexto22.Close();

                Nota22.Text = Str_Leitura;

            }

            if (File.Exists("Nota23.txt"))
            {
                fluxoTexto23 = new StreamReader("Nota23.txt");
                linhaTexto = fluxoTexto23.ReadLine();
                String Str_Leitura = "";


                while (linhaTexto != null)
                {
                    Str_Leitura += linhaTexto + Environment.NewLine;
                    linhaTexto = fluxoTexto23.ReadLine();
                }

                fluxoTexto23.Close();

                Nota23.Text = Str_Leitura;

            }

            if (File.Exists("Nota24.txt"))
            {
                fluxoTexto24 = new StreamReader("Nota24.txt");
                linhaTexto = fluxoTexto24.ReadLine();
                String Str_Leitura = "";


                while (linhaTexto != null)
                {
                    Str_Leitura += linhaTexto + Environment.NewLine;
                    linhaTexto = fluxoTexto24.ReadLine();
                }

                fluxoTexto24.Close();

                Nota24.Text = Str_Leitura;

            }

            if (File.Exists("Nota25.txt"))
            {
                fluxoTexto25 = new StreamReader("Nota25.txt");
                linhaTexto = fluxoTexto25.ReadLine();
                String Str_Leitura = "";


                while (linhaTexto != null)
                {
                    Str_Leitura += linhaTexto + Environment.NewLine;
                    linhaTexto = fluxoTexto25.ReadLine();
                }

                fluxoTexto25.Close();

                Nota25.Text = Str_Leitura;

            }

            if (File.Exists("Nota26.txt"))
            {
                fluxoTexto26 = new StreamReader("Nota26.txt");
                linhaTexto = fluxoTexto26.ReadLine();
                String Str_Leitura = "";


                while (linhaTexto != null)
                {
                    Str_Leitura += linhaTexto + Environment.NewLine;
                    linhaTexto = fluxoTexto26.ReadLine();
                }

                fluxoTexto26.Close();

                Nota26.Text = Str_Leitura;

            }

            if (File.Exists("Nota27.txt"))
            {
                fluxoTexto27 = new StreamReader("Nota27.txt");
                linhaTexto = fluxoTexto27.ReadLine();
                String Str_Leitura = "";


                while (linhaTexto != null)
                {
                    Str_Leitura += linhaTexto + Environment.NewLine;
                    linhaTexto = fluxoTexto27.ReadLine();
                }

                fluxoTexto27.Close();

                Nota27.Text = Str_Leitura;

            }

            if (File.Exists("Nota28.txt"))
            {
                fluxoTexto28 = new StreamReader("Nota28.txt");
                linhaTexto = fluxoTexto28.ReadLine();
                String Str_Leitura = "";


                while (linhaTexto != null)
                {
                    Str_Leitura += linhaTexto + Environment.NewLine;
                    linhaTexto = fluxoTexto28.ReadLine();
                }

                fluxoTexto28.Close();

                Nota28.Text = Str_Leitura;

            }

            if (File.Exists("Nota29.txt"))
            {
                fluxoTexto29 = new StreamReader("Nota29.txt");
                linhaTexto = fluxoTexto29.ReadLine();
                String Str_Leitura = "";


                while (linhaTexto != null)
                {
                    Str_Leitura += linhaTexto + Environment.NewLine;
                    linhaTexto = fluxoTexto29.ReadLine();
                }

                fluxoTexto29.Close();

                Nota29.Text = Str_Leitura;

            }

            if (File.Exists("Nota30.txt"))
            {
                fluxoTexto30 = new StreamReader("Nota30.txt");
                linhaTexto = fluxoTexto30.ReadLine();
                String Str_Leitura = "";


                while (linhaTexto != null)
                {
                    Str_Leitura += linhaTexto + Environment.NewLine;
                    linhaTexto = fluxoTexto30.ReadLine();
                }

                fluxoTexto30.Close();

                Nota30.Text = Str_Leitura;

            }

            if (File.Exists("Nota31.txt"))
            {
                fluxoTexto31 = new StreamReader("Nota31.txt");
                linhaTexto = fluxoTexto31.ReadLine();
                String Str_Leitura = "";


                while (linhaTexto != null)
                {
                    Str_Leitura += linhaTexto + Environment.NewLine;
                    linhaTexto = fluxoTexto31.ReadLine();
                }

                fluxoTexto31.Close();

                Nota31.Text = Str_Leitura;

            }

            if (File.Exists("Nota32.txt"))
            {
                fluxoTexto32 = new StreamReader("Nota32.txt");
                linhaTexto = fluxoTexto32.ReadLine();
                String Str_Leitura = "";


                while (linhaTexto != null)
                {
                    Str_Leitura += linhaTexto + Environment.NewLine;
                    linhaTexto = fluxoTexto32.ReadLine();
                }

                fluxoTexto32.Close();

                Nota32.Text = Str_Leitura;

            }

            if (File.Exists("Nota33.txt"))
            {
                fluxoTexto33 = new StreamReader("Nota33.txt");
                linhaTexto = fluxoTexto33.ReadLine();
                String Str_Leitura = "";


                while (linhaTexto != null)
                {
                    Str_Leitura += linhaTexto + Environment.NewLine;
                    linhaTexto = fluxoTexto33.ReadLine();
                }

                fluxoTexto33.Close();

                Nota33.Text = Str_Leitura;

            }

            if (File.Exists("Nota34.txt"))
            {
                fluxoTexto34 = new StreamReader("Nota34.txt");
                linhaTexto = fluxoTexto34.ReadLine();
                String Str_Leitura = "";


                while (linhaTexto != null)
                {
                    Str_Leitura += linhaTexto + Environment.NewLine;
                    linhaTexto = fluxoTexto34.ReadLine();
                }

                fluxoTexto34.Close();

                Nota34.Text = Str_Leitura;

            }







        }




        // usado para tirar o X padrão do formulario
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);



        private void Notas_Load(object sender, EventArgs e)
        {


            //cria time

            contador = new System.Timers.Timer();
            contador.Interval = 1000;
            contador.Elapsed += CheckTime;

            contador2 = new System.Timers.Timer();
            contador2.Interval = 1000;
            contador2.Elapsed += CheckTime2;

            contador3 = new System.Timers.Timer();
            contador3.Interval = 1000;
            contador3.Elapsed += CheckTime3;

            contador4 = new System.Timers.Timer();
            contador4.Interval = 1000;
            contador4.Elapsed += CheckTime4;

            contador5 = new System.Timers.Timer();
            contador5.Interval = 1000;
            contador5.Elapsed += CheckTime5;

            contador6 = new System.Timers.Timer();
            contador6.Interval = 1000;
            contador6.Elapsed += CheckTime6;

            contador7 = new System.Timers.Timer();
            contador7.Interval = 1000;
            contador7.Elapsed += CheckTime7;

            contador8 = new System.Timers.Timer();
            contador8.Interval = 1000;
            contador8.Elapsed += CheckTime8;

            contador9 = new System.Timers.Timer();
            contador9.Interval = 1000;
            contador9.Elapsed += CheckTime9;

            contador10 = new System.Timers.Timer();
            contador10.Interval = 1000;
            contador10.Elapsed += CheckTime10;

            contador11 = new System.Timers.Timer();
            contador11.Interval = 1000;
            contador11.Elapsed += CheckTime11;

            contador12 = new System.Timers.Timer();
            contador12.Interval = 1000;
            contador12.Elapsed += CheckTime12;

            contador13 = new System.Timers.Timer();
            contador13.Interval = 1000;
            contador13.Elapsed += CheckTime13;

            contador14 = new System.Timers.Timer();
            contador14.Interval = 1000;
            contador14.Elapsed += CheckTime14;

            contador15 = new System.Timers.Timer();
            contador15.Interval = 1000;
            contador15.Elapsed += CheckTime15;

            contador16 = new System.Timers.Timer();
            contador16.Interval = 1000;
            contador16.Elapsed += CheckTime16;

            contador17 = new System.Timers.Timer();
            contador17.Interval = 1000;
            contador17.Elapsed += CheckTime17;

            contador18 = new System.Timers.Timer();
            contador18.Interval = 1000;
            contador18.Elapsed += CheckTime18;

            contador19 = new System.Timers.Timer();
            contador19.Interval = 1000;
            contador19.Elapsed += CheckTime19;

            contador20 = new System.Timers.Timer();
            contador20.Interval = 1000;
            contador20.Elapsed += CheckTime20;

            contador21 = new System.Timers.Timer();
            contador21.Interval = 1000;
            contador21.Elapsed += CheckTime21;

            contador22 = new System.Timers.Timer();
            contador22.Interval = 1000;
            contador22.Elapsed += CheckTime22;

            contador23 = new System.Timers.Timer();
            contador23.Interval = 1000;
            contador23.Elapsed += CheckTime23;

            contador24 = new System.Timers.Timer();
            contador24.Interval = 1000;
            contador24.Elapsed += CheckTime24;

            contador25 = new System.Timers.Timer();
            contador25.Interval = 1000;
            contador25.Elapsed += CheckTime25;

            contador26 = new System.Timers.Timer();
            contador26.Interval = 1000;
            contador26.Elapsed += CheckTime26;

            contador27 = new System.Timers.Timer();
            contador27.Interval = 1000;
            contador27.Elapsed += CheckTime27;

            contador28 = new System.Timers.Timer();
            contador28.Interval = 1000;
            contador28.Elapsed += CheckTime28;

            contador29 = new System.Timers.Timer();
            contador29.Interval = 1000;
            contador29.Elapsed += CheckTime29;

            contador30 = new System.Timers.Timer();
            contador30.Interval = 1000;
            contador30.Elapsed += CheckTime30;

            contador31 = new System.Timers.Timer();
            contador31.Interval = 1000;
            contador31.Elapsed += CheckTime31;

            contador32 = new System.Timers.Timer();
            contador32.Interval = 1000;
            contador32.Elapsed += CheckTime32;

            contador33 = new System.Timers.Timer();
            contador33.Interval = 1000;
            contador33.Elapsed += CheckTime33;

            contador34 = new System.Timers.Timer();
            contador34.Interval = 1000;
            contador34.Elapsed += CheckTime34;







            // usado para tirar o X padrão do formulario
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);

            ler_texto_salvo();

            VerificaVazio();

            // verificar as cores

            


        }





        // botões de alerta
        private void btnAlerta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para adicionar uma Nota clique no Botão esquerdo abaixo!!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAlerta2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para remover uma Nota clique no Botão direito abaixo!!!!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAlerta3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para marcar uma Atividade como concluida clique no Botão de check à direita da nota!!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnAlerta4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para marcar um alarme basta apenas seleionar o dia e hora na caixa de Horas e clicar no botão MARCAR", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //botões de ADD


        private void buttonStart_Click(object sender, EventArgs e)
        {

            AcoesButtonAdd(Nota0, buttonExcluirStart, checknota1, button1, btnMarcar, Timer1);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AcoesButtonAdd(Nota2, buttonExcluir2, checknota2, button2, btnMarcar2, Timer2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AcoesButtonAdd(Nota3, buttonExcluir3, checknota3, button3, btnMarcar3, Timer3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AcoesButtonAdd(Nota4, buttonExcluir4, checknota4, button4, btnMarcar4, Timer4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AcoesButtonAdd(Nota5, buttonExcluir5, checknota5, button5, btnMarcar5, Timer5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AcoesButtonAdd(Nota6, buttonExcluir6, checknota6, button6, btnMarcar6, Timer6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AcoesButtonAdd(Nota7, buttonExcluir7, checknota7, button7, btnMarcar7, Timer7);

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            AcoesButtonAdd(Nota8, buttonExcluir8, checknota8, button8, btnMarcar8, Timer8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AcoesButtonAdd(Nota9, buttonExcluir9, checknota9, button9, btnMarcar9, Timer9);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            AcoesButtonAdd(Nota10, buttonExcluir10, checknota10, button10, btnMarcar10, Timer10);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            AcoesButtonAdd(Nota11, buttonExcluir11, checknota11, button11, btnMarcar11, Timer11);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            AcoesButtonAdd(Nota12, buttonExcluir12, checknota12, button12, btnMarcar12, Timer12);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            AcoesButtonAdd(Nota13, buttonExcluir13, checknota13, button13, btnMarcar13, Timer13);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            AcoesButtonAdd(Nota14, buttonExcluir14, checknota14, button14, btnMarcar14, Timer14);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            AcoesButtonAdd(Nota15, buttonExcluir15, checknota15, button15, btnMarcar15, Timer15);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            AcoesButtonAdd(Nota16, buttonExcluir16, checknota16, button16, btnMarcar16, Timer16);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            AcoesButtonAdd(Nota17, buttonExcluir17, checknota17, button17, btnMarcar17, Timer17);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            AcoesButtonAdd(Nota18, buttonExcluir18, checknota18, button18, btnMarcar18, Timer18);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            AcoesButtonAdd(Nota19, buttonExcluir19, checknota19, button19, btnMarcar19, Timer19);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            AcoesButtonAdd(Nota20, buttonExcluir20, checknota20, button20, btnMarcar20, Timer20);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            AcoesButtonAdd(Nota21, buttonExcluir21, checknota21, button21, btnMarcar21, Timer21);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            AcoesButtonAdd(Nota22, buttonExcluir22, checknota22, button22, btnMarcar22, Timer22);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            AcoesButtonAdd(Nota23, buttonExcluir23, checknota23, button23, btnMarcar23, Timer23);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            AcoesButtonAdd(Nota24, buttonExcluir24, checknota24, button24, btnMarcar24, Timer24);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            AcoesButtonAdd(Nota25, buttonExcluir25, checknota25, button25, btnMarcar25, Timer25);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            AcoesButtonAdd(Nota26, buttonExcluir26, checknota26, button26, btnMarcar26, Timer26);

        }

        private void button27_Click(object sender, EventArgs e)
        {
            AcoesButtonAdd(Nota27, buttonExcluir27, checknota27, button27, btnMarcar27, Timer27);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            AcoesButtonAdd(Nota28, buttonExcluir28, checknota28, button28, btnMarcar28, Timer28);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            AcoesButtonAdd(Nota29, buttonExcluir29, checknota29, button29, btnMarcar29, Timer29);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            AcoesButtonAdd(Nota30, buttonExcluir30, checknota30, button30, btnMarcar30, Timer30);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            AcoesButtonAdd(Nota31, buttonExcluir31, checknota31, button31, btnMarcar31, Timer31);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            AcoesButtonAdd(Nota32, buttonExcluir32, checknota32, button32, btnMarcar32, Timer32);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            AcoesButtonAdd(Nota33, buttonExcluir33, checknota33, button33, btnMarcar33, Timer33);

        }

        private void button34_Click(object sender, EventArgs e)
        {
            AcoesButtonAdd(Nota34, buttonExcluir34, checknota34, button34, btnMarcar34, Timer34);
        }



        // Botões de Exclusão



        private void buttonExcluirStart_Click(object sender, EventArgs e)
        {

            AcoesButtonRemove(Nota0, buttonExcluirStart, checknota1, button1, btnMarcar, Timer1);


        }

        private void buttonExcluir2_Click(object sender, EventArgs e)
        {
            AcoesButtonRemove(Nota2, buttonExcluir2, checknota2, button2, btnMarcar2, Timer2);

        }

        private void buttonExcluir3_Click(object sender, EventArgs e)
        {

            AcoesButtonRemove(Nota3, buttonExcluir3, checknota3, button3, btnMarcar3, Timer3);

        }

        private void buttonExcluir4_Click(object sender, EventArgs e)
        {
            AcoesButtonRemove(Nota4, buttonExcluir4, checknota4, button4, btnMarcar4, Timer4);

        }

        private void buttonExcluir5_Click(object sender, EventArgs e)
        {
            AcoesButtonRemove(Nota5, buttonExcluir5, checknota5, button5, btnMarcar6, Timer5);

        }

        private void buttonExcluir6_Click(object sender, EventArgs e)
        {

            AcoesButtonRemove(Nota6, buttonExcluir6, checknota6, button6, btnMarcar6, Timer6);

        }

        private void buttonExcluir7_Click(object sender, EventArgs e)
        {
            AcoesButtonRemove(Nota7, buttonExcluir7, checknota7, button7, btnMarcar7, Timer7);

        }

        private void buttonExcluir8_Click(object sender, EventArgs e)
        {

            AcoesButtonRemove(Nota8, buttonExcluir8, checknota8, button8, btnMarcar8, Timer8);

        }

        private void buttonExcluir9_Click(object sender, EventArgs e)
        {

            AcoesButtonRemove(Nota9, buttonExcluir9, checknota9, button9, btnMarcar9, Timer9);

        }

        private void buttonExcluir10_Click(object sender, EventArgs e)
        {
            AcoesButtonRemove(Nota10, buttonExcluir10, checknota10, button10, btnMarcar10, Timer10);

        }

        private void buttonExcluir11_Click(object sender, EventArgs e)
        {
            AcoesButtonRemove(Nota11, buttonExcluir11, checknota11, button11, btnMarcar11, Timer11);

        }

        private void buttonExcluir12_Click(object sender, EventArgs e)
        {
            AcoesButtonRemove(Nota12, buttonExcluir12, checknota12, button12, btnMarcar12, Timer12);

        }

        private void buttonExcluir13_Click(object sender, EventArgs e)
        {
            AcoesButtonRemove(Nota13, buttonExcluir13, checknota13, button13, btnMarcar13, Timer13);
        }

        private void buttonExcluir14_Click(object sender, EventArgs e)
        {
            AcoesButtonRemove(Nota14, buttonExcluir14, checknota14, button14, btnMarcar14, Timer14);
        }

        private void buttonExcluir15_Click(object sender, EventArgs e)
        {
            AcoesButtonRemove(Nota15, buttonExcluir15, checknota15, button15, btnMarcar15, Timer15);
        }

        private void buttonExcluir16_Click(object sender, EventArgs e)
        {
            AcoesButtonRemove(Nota16, buttonExcluir16, checknota16, button16, btnMarcar16, Timer16);

        }

        private void buttonExcluir17_Click(object sender, EventArgs e)
        {

            AcoesButtonRemove(Nota17, buttonExcluir17, checknota17, button17, btnMarcar17, Timer17);

        }

        private void buttonExcluir18_Click(object sender, EventArgs e)
        {
            AcoesButtonRemove(Nota18, buttonExcluir18, checknota18, button18, btnMarcar18, Timer18);
        }

        private void buttonExcluir19_Click(object sender, EventArgs e)
        {
            AcoesButtonRemove(Nota19, buttonExcluir19, checknota19, button19, btnMarcar19, Timer19);
        }

        private void buttonExcluir20_Click(object sender, EventArgs e)
        {
            AcoesButtonRemove(Nota20, buttonExcluir20, checknota20, button20, btnMarcar20, Timer20);

        }

        private void buttonExcluir21_Click(object sender, EventArgs e)
        {
            AcoesButtonRemove(Nota21, buttonExcluir21, checknota21, button21, btnMarcar21, Timer21);

        }

        private void buttonExcluir22_Click(object sender, EventArgs e)
        {
            AcoesButtonRemove(Nota22, buttonExcluir22, checknota22, button22, btnMarcar22, Timer22);
        }

        private void buttonExcluir23_Click(object sender, EventArgs e)
        {
            AcoesButtonRemove(Nota23, buttonExcluir23, checknota23, button23, btnMarcar23, Timer23);
        }

        private void buttonExcluir24_Click(object sender, EventArgs e)
        {
            AcoesButtonRemove(Nota24, buttonExcluir24, checknota24, button24, btnMarcar24, Timer24);
        }

        private void buttonExcluir25_Click(object sender, EventArgs e)
        {
            AcoesButtonRemove(Nota25, buttonExcluir25, checknota25, button25, btnMarcar25, Timer25);
        }

        private void buttonExcluir26_Click(object sender, EventArgs e)
        {
            AcoesButtonRemove(Nota26, buttonExcluir26, checknota26, button26, btnMarcar26, Timer26);
        }

        private void buttonExcluir27_Click(object sender, EventArgs e)
        {
            AcoesButtonRemove(Nota27, buttonExcluir27, checknota27, button27, btnMarcar27, Timer27);
        }

        private void buttonExcluir28_Click(object sender, EventArgs e)
        {
            AcoesButtonRemove(Nota28, buttonExcluir28, checknota28, button28, btnMarcar28, Timer28);
        }

        private void buttonExcluir29_Click(object sender, EventArgs e)
        {
            AcoesButtonRemove(Nota29, buttonExcluir29, checknota29, button29, btnMarcar29, Timer29);
        }

        private void buttonExcluir30_Click(object sender, EventArgs e)
        {
            AcoesButtonRemove(Nota30, buttonExcluir30, checknota30, button30, btnMarcar30, Timer30);
        }

        private void buttonExcluir31_Click(object sender, EventArgs e)
        {
            AcoesButtonRemove(Nota31, buttonExcluir31, checknota31, button31, btnMarcar31, Timer31);
        }

        private void buttonExcluir32_Click(object sender, EventArgs e)
        {
            AcoesButtonRemove(Nota32, buttonExcluir32, checknota32, button32, btnMarcar32, Timer32);
        }

        private void buttonExcluir33_Click(object sender, EventArgs e)
        {
            AcoesButtonRemove(Nota33, buttonExcluir33, checknota33, button33, btnMarcar33, Timer33);
        }

        private void buttonExcluir34_Click(object sender, EventArgs e)
        {
            AcoesButtonRemove(Nota34, buttonExcluir34, checknota34, button34, btnMarcar34, Timer34);
        }


        // Link para o gihub


        private void GitHub_Click(object sender, EventArgs e)
        {

            // abre um link externo no navegador do usuario
            System.Diagnostics.Process.Start("https://github.com/ViniciusLimaSilva");

        }

        // botão para sair

        private void btnSair_Click(object sender, EventArgs e)
        {
            salva_texto();

            Application.Exit();


        }



        // Botões para check de conclusão das atividades

        private void checknota1_CheckedChanged(object sender, EventArgs e)
        {
            MarcaCheckBox(Nota0, buttonExcluirStart, checknota1, button1, btnMarcar, Timer1, contador);
        }

        private void checknota2_CheckedChanged(object sender, EventArgs e)
        {
            MarcaCheckBox(Nota2, buttonExcluir2, checknota2, button2, btnMarcar2, Timer2, contador2);
        }

        private void checknota3_CheckedChanged(object sender, EventArgs e)
        {
            MarcaCheckBox(Nota3, buttonExcluir3, checknota3, button3, btnMarcar3, Timer3, contador3);
        }

        private void checknota4_CheckedChanged(object sender, EventArgs e)
        {
            MarcaCheckBox(Nota4, buttonExcluir4, checknota4, button4, btnMarcar4, Timer4, contador4);
        }

        private void checknota5_CheckedChanged(object sender, EventArgs e)
        {
            MarcaCheckBox(Nota5, buttonExcluir5, checknota5, button5, btnMarcar5, Timer5, contador5);
        }

        private void checknota6_CheckedChanged(object sender, EventArgs e)
        {
            MarcaCheckBox(Nota6, buttonExcluir6, checknota6, button6, btnMarcar6, Timer6, contador6);
        }

        private void checknota7_CheckedChanged(object sender, EventArgs e)
        {
            MarcaCheckBox(Nota7, buttonExcluir7, checknota7, button7, btnMarcar7, Timer7, contador7);
        }

        private void checknota8_CheckedChanged(object sender, EventArgs e)
        {
            MarcaCheckBox(Nota8, buttonExcluir8, checknota8, button8, btnMarcar8, Timer8, contador8);
        }

        private void checknota9_CheckedChanged(object sender, EventArgs e)
        {
            MarcaCheckBox(Nota9, buttonExcluir9, checknota9, button9, btnMarcar9, Timer9, contador9);
        }

        private void checknota10_CheckedChanged(object sender, EventArgs e)
        {
            MarcaCheckBox(Nota10, buttonExcluir10, checknota10, button10, btnMarcar10, Timer10, contador10);
        }

        private void checknota11_CheckedChanged(object sender, EventArgs e)
        {
            MarcaCheckBox(Nota11, buttonExcluir11, checknota11, button11, btnMarcar11, Timer11, contador11);
        }

        private void checknota12_CheckedChanged(object sender, EventArgs e)
        {
            MarcaCheckBox(Nota12, buttonExcluir12, checknota12, button12, btnMarcar12, Timer12, contador12);
        }

        private void checknota13_CheckedChanged(object sender, EventArgs e)
        {
            MarcaCheckBox(Nota13, buttonExcluir13, checknota13, button13, btnMarcar13, Timer13, contador13);
        }

        private void checknota14_CheckedChanged(object sender, EventArgs e)
        {
            MarcaCheckBox(Nota14, buttonExcluir14, checknota14, button14, btnMarcar14, Timer14, contador14);
        }

        private void checknota15_CheckedChanged(object sender, EventArgs e)
        {
            MarcaCheckBox(Nota15, buttonExcluir15, checknota15, button15, btnMarcar15, Timer15, contador15);
        }

        private void checknota16_CheckedChanged(object sender, EventArgs e)
        {
            MarcaCheckBox(Nota16, buttonExcluir16, checknota16, button16, btnMarcar16, Timer16, contador16);
        }

        private void checknota17_CheckedChanged(object sender, EventArgs e)
        {
            MarcaCheckBox(Nota17, buttonExcluir17, checknota17, button17, btnMarcar17, Timer17, contador17);
        }

        private void checknota18_CheckedChanged(object sender, EventArgs e)
        {
            MarcaCheckBox(Nota18, buttonExcluir18, checknota18, button18, btnMarcar18, Timer18, contador18);
        }

        private void checknota19_CheckedChanged(object sender, EventArgs e)
        {
            MarcaCheckBox(Nota19, buttonExcluir19, checknota19, button19, btnMarcar19, Timer19, contador19);
        }

        private void checknota20_CheckedChanged(object sender, EventArgs e)
        {
            MarcaCheckBox(Nota20, buttonExcluir20, checknota20, button20, btnMarcar20, Timer20, contador20);
        }

        private void checknota21_CheckedChanged(object sender, EventArgs e)
        {
            MarcaCheckBox(Nota21, buttonExcluir21, checknota21, button21, btnMarcar21, Timer21, contador21);
        }

        private void checknota22_CheckedChanged(object sender, EventArgs e)
        {
            MarcaCheckBox(Nota22, buttonExcluir22, checknota22, button22, btnMarcar22, Timer22, contador22);
        }

        private void checknota23_CheckedChanged(object sender, EventArgs e)
        {
            MarcaCheckBox(Nota23, buttonExcluir23, checknota23, button23, btnMarcar23, Timer23, contador23);
        }

        private void checknota24_CheckedChanged(object sender, EventArgs e)
        {
            MarcaCheckBox(Nota24, buttonExcluir24, checknota24, button24, btnMarcar24, Timer24, contador24);
        }

        private void checknota25_CheckedChanged(object sender, EventArgs e)
        {
            MarcaCheckBox(Nota25, buttonExcluir25, checknota25, button25, btnMarcar25, Timer25, contador25);
        }

        private void checknota26_CheckedChanged(object sender, EventArgs e)
        {
            MarcaCheckBox(Nota26, buttonExcluir26, checknota26, button26, btnMarcar26, Timer26, contador26);
        }

        private void checknota27_CheckedChanged(object sender, EventArgs e)
        {
            MarcaCheckBox(Nota27, buttonExcluir27, checknota27, button27, btnMarcar27, Timer27, contador27);
        }

        private void checknota28_CheckedChanged(object sender, EventArgs e)
        {
            MarcaCheckBox(Nota28, buttonExcluir28, checknota28, button28, btnMarcar28, Timer28, contador28);
        }

        private void checknota29_CheckedChanged(object sender, EventArgs e)
        {
            MarcaCheckBox(Nota29, buttonExcluir29, checknota29, button29, btnMarcar29, Timer29, contador29);
        }

        private void checknota30_CheckedChanged(object sender, EventArgs e)
        {
            MarcaCheckBox(Nota30, buttonExcluir30, checknota30, button30, btnMarcar30, Timer30, contador30);
        }

        private void checknota31_CheckedChanged(object sender, EventArgs e)
        {
            MarcaCheckBox(Nota31, buttonExcluir31, checknota31, button31, btnMarcar31, Timer31, contador31);
        }

        private void checknota32_CheckedChanged(object sender, EventArgs e)
        {
            MarcaCheckBox(Nota32, buttonExcluir32, checknota32, button32, btnMarcar32, Timer32, contador32);
        }

        private void checknota33_CheckedChanged(object sender, EventArgs e)
        {
            MarcaCheckBox(Nota33, buttonExcluir33, checknota33, button33, btnMarcar33, Timer33, contador33);
        }

        private void checknota34_CheckedChanged(object sender, EventArgs e)
        {
            MarcaCheckBox(Nota34, buttonExcluir34, checknota34, button34, btnMarcar34, Timer34, contador34);
        }


        // botão para marcar time
        private void btnMarcar1_Click(object sender, EventArgs e)
        {
            if(Timer1.Value.Hour < DateTime.Now.Hour || Timer1.Value.Minute < DateTime.Now.Minute || Timer1.Value.Second <= DateTime.Now.Second)
            {
                MessageBox.Show("Horario Inválido, Tente novamente!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                contador.Start();
                Timer1.Enabled = false;
                btnMarcar.Enabled = false;
                MessageBox.Show("Horário Marcado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show("Caso tenha concluido a tarefa lembre-se de dar o Check!!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }

        }

        private void btnMarcar2_Click(object sender, EventArgs e)
        {

            if (Timer2.Value.Hour < DateTime.Now.Hour || Timer2.Value.Minute < DateTime.Now.Minute || Timer2.Value.Second <= DateTime.Now.Second)
            {
                MessageBox.Show("Horario Inválido, Tente novamente!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                contador2.Start();
                Timer2.Enabled = false;
                btnMarcar2.Enabled = false;
                MessageBox.Show("Horário Marcado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show("Caso tenha concluido a tarefa lembre-se de dar o Check!!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnMarcar3_Click(object sender, EventArgs e)
        {
            if (Timer3.Value.Hour < DateTime.Now.Hour || Timer3.Value.Minute < DateTime.Now.Minute || Timer3.Value.Second <= DateTime.Now.Second)
            {
                MessageBox.Show("Horario Inválido, Tente novamente!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                contador3.Start();
                Timer3.Enabled = false;
                btnMarcar3.Enabled = false;
                MessageBox.Show("Horário Marcado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show("Caso tenha concluido a tarefa lembre-se de dar o Check!!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnMarcar4_Click(object sender, EventArgs e)
        {
            if (Timer4.Value.Hour < DateTime.Now.Hour || Timer4.Value.Minute < DateTime.Now.Minute || Timer4.Value.Second <= DateTime.Now.Second)
            {
                MessageBox.Show("Horario Inválido, Tente novamente!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                contador4.Start();
                Timer4.Enabled = false;
                btnMarcar4.Enabled = false;
                MessageBox.Show("Horário Marcado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show("Caso tenha concluido a tarefa lembre-se de dar o Check!!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnMarcar5_Click(object sender, EventArgs e)
        {
            if (Timer5.Value.Hour < DateTime.Now.Hour || Timer5.Value.Minute < DateTime.Now.Minute || Timer5.Value.Second <= DateTime.Now.Second)
            {
                MessageBox.Show("Horario Inválido, Tente novamente!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                contador5.Start();
                Timer5.Enabled = false;
                btnMarcar5.Enabled = false;
                MessageBox.Show("Horário Marcado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show("Caso tenha concluido a tarefa lembre-se de dar o Check!!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnMarcar6_Click(object sender, EventArgs e)
        {
            if (Timer6.Value.Hour < DateTime.Now.Hour || Timer6.Value.Minute < DateTime.Now.Minute || Timer6.Value.Second <= DateTime.Now.Second)
            {
                MessageBox.Show("Horario Inválido, Tente novamente!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                contador6.Start();
                Timer6.Enabled = false;
                btnMarcar6.Enabled = false;
                MessageBox.Show("Horário Marcado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show("Caso tenha concluido a tarefa lembre-se de dar o Check!!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnMarcar7_Click(object sender, EventArgs e)
        {
            if (Timer7.Value.Hour < DateTime.Now.Hour || Timer7.Value.Minute < DateTime.Now.Minute || Timer7.Value.Second <= DateTime.Now.Second)
            {
                MessageBox.Show("Horario Inválido, Tente novamente!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                contador7.Start();
                Timer7.Enabled = false;
                btnMarcar7.Enabled = false;
                MessageBox.Show("Horário Marcado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show("Caso tenha concluido a tarefa lembre-se de dar o Check!!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnMarcar8_Click(object sender, EventArgs e)
        {
            if (Timer8.Value.Hour < DateTime.Now.Hour || Timer8.Value.Minute < DateTime.Now.Minute || Timer8.Value.Second <= DateTime.Now.Second)
            {
                MessageBox.Show("Horario Inválido, Tente novamente!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                contador8.Start();
                Timer8.Enabled = false;
                btnMarcar8.Enabled = false;
                MessageBox.Show("Horário Marcado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show("Caso tenha concluido a tarefa lembre-se de dar o Check!!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnMarcar9_Click(object sender, EventArgs e)
        {
            if (Timer9.Value.Hour < DateTime.Now.Hour || Timer9.Value.Minute < DateTime.Now.Minute || Timer9.Value.Second <= DateTime.Now.Second)
            {
                MessageBox.Show("Horario Inválido, Tente novamente!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                contador9.Start();
                Timer9.Enabled = false;
                btnMarcar9.Enabled = false;
                MessageBox.Show("Horário Marcado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show("Caso tenha concluido a tarefa lembre-se de dar o Check!!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnMarcar10_Click(object sender, EventArgs e)
        {
            if (Timer10.Value.Hour < DateTime.Now.Hour || Timer10.Value.Minute < DateTime.Now.Minute || Timer10.Value.Second <= DateTime.Now.Second)
            {
                MessageBox.Show("Horario Inválido, Tente novamente!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                contador10.Start();
                Timer10.Enabled = false;
                btnMarcar10.Enabled = false;
                MessageBox.Show("Horário Marcado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show("Caso tenha concluido a tarefa lembre-se de dar o Check!!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnMarcar11_Click(object sender, EventArgs e)
        {
            if (Timer11.Value.Hour < DateTime.Now.Hour || Timer11.Value.Minute < DateTime.Now.Minute || Timer11.Value.Second <= DateTime.Now.Second)
            {
                MessageBox.Show("Horario Inválido, Tente novamente!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                contador11.Start();
                Timer11.Enabled = false;
                btnMarcar11.Enabled = false;
                MessageBox.Show("Horário Marcado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show("Caso tenha concluido a tarefa lembre-se de dar o Check!!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnMarcar12_Click(object sender, EventArgs e)
        {
            if (Timer12.Value.Hour < DateTime.Now.Hour || Timer12.Value.Minute < DateTime.Now.Minute || Timer12.Value.Second <= DateTime.Now.Second)
            {
                MessageBox.Show("Horario Inválido, Tente novamente!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                contador12.Start();
                Timer12.Enabled = false;
                btnMarcar12.Enabled = false;
                MessageBox.Show("Horário Marcado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show("Caso tenha concluido a tarefa lembre-se de dar o Check!!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnMarcar13_Click(object sender, EventArgs e)
        {
            if (Timer13.Value.Hour < DateTime.Now.Hour || Timer13.Value.Minute < DateTime.Now.Minute || Timer13.Value.Second <= DateTime.Now.Second)
            {
                MessageBox.Show("Horario Inválido, Tente novamente!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                contador13.Start();
                Timer13.Enabled = false;
                btnMarcar13.Enabled = false;
                MessageBox.Show("Horário Marcado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show("Caso tenha concluido a tarefa lembre-se de dar o Check!!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnMarcar14_Click(object sender, EventArgs e)
        {
            if (Timer14.Value.Hour < DateTime.Now.Hour || Timer14.Value.Minute < DateTime.Now.Minute || Timer14.Value.Second <= DateTime.Now.Second)
            {
                MessageBox.Show("Horario Inválido, Tente novamente!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                contador14.Start();
                Timer14.Enabled = false;
                btnMarcar14.Enabled = false;
                MessageBox.Show("Horário Marcado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show("Caso tenha concluido a tarefa lembre-se de dar o Check!!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnMarcar15_Click(object sender, EventArgs e)
        {
            if (Timer15.Value.Hour < DateTime.Now.Hour || Timer15.Value.Minute < DateTime.Now.Minute || Timer15.Value.Second <= DateTime.Now.Second)
            {
                MessageBox.Show("Horario Inválido, Tente novamente!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                contador15.Start();
                Timer15.Enabled = false;
                btnMarcar15.Enabled = false;
                MessageBox.Show("Horário Marcado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show("Caso tenha concluido a tarefa lembre-se de dar o Check!!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnMarcar16_Click(object sender, EventArgs e)
        {
            if (Timer16.Value.Hour < DateTime.Now.Hour || Timer16.Value.Minute < DateTime.Now.Minute || Timer16.Value.Second <= DateTime.Now.Second)
            {
                MessageBox.Show("Horario Inválido, Tente novamente!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                contador16.Start();
                Timer16.Enabled = false;
                btnMarcar16.Enabled = false;
                MessageBox.Show("Horário Marcado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show("Caso tenha concluido a tarefa lembre-se de dar o Check!!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnMarcar17_Click(object sender, EventArgs e)
        {
            if (Timer17.Value.Hour < DateTime.Now.Hour || Timer17.Value.Minute < DateTime.Now.Minute || Timer17.Value.Second <= DateTime.Now.Second)
            {
                MessageBox.Show("Horario Inválido, Tente novamente!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                contador17.Start();
                Timer17.Enabled = false;
                btnMarcar17.Enabled = false;
                MessageBox.Show("Horário Marcado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show("Caso tenha concluido a tarefa lembre-se de dar o Check!!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnMarcar18_Click(object sender, EventArgs e)
        {
            if (Timer18.Value.Hour < DateTime.Now.Hour || Timer18.Value.Minute < DateTime.Now.Minute || Timer18.Value.Second <= DateTime.Now.Second)
            {
                MessageBox.Show("Horario Inválido, Tente novamente!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                contador18.Start();
                Timer18.Enabled = false;
                btnMarcar18.Enabled = false;
                MessageBox.Show("Horário Marcado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show("Caso tenha concluido a tarefa lembre-se de dar o Check!!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnMarcar19_Click(object sender, EventArgs e)
        {
            if (Timer19.Value.Hour < DateTime.Now.Hour || Timer19.Value.Minute < DateTime.Now.Minute || Timer19.Value.Second <= DateTime.Now.Second)
            {
                MessageBox.Show("Horario Inválido, Tente novamente!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                contador19.Start();
                Timer19.Enabled = false;
                btnMarcar19.Enabled = false;
                MessageBox.Show("Horário Marcado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show("Caso tenha concluido a tarefa lembre-se de dar o Check!!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnMarcar20_Click(object sender, EventArgs e)
        {

            if (Timer20.Value.Hour < DateTime.Now.Hour || Timer20.Value.Minute < DateTime.Now.Minute || Timer20.Value.Second <= DateTime.Now.Second)
            {
                MessageBox.Show("Horario Inválido, Tente novamente!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                contador20.Start();
                Timer20.Enabled = false;
                btnMarcar20.Enabled = false;
                MessageBox.Show("Horário Marcado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show("Caso tenha concluido a tarefa lembre-se de dar o Check!!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
        private void btnMarcar21_Click(object sender, EventArgs e)
        {
            if (Timer21.Value.Hour < DateTime.Now.Hour || Timer21.Value.Minute < DateTime.Now.Minute || Timer21.Value.Second <= DateTime.Now.Second)
            {
                MessageBox.Show("Horario Inválido, Tente novamente!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                contador21.Start();
                Timer21.Enabled = false;
                btnMarcar21.Enabled = false;
                MessageBox.Show("Horário Marcado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show("Caso tenha concluido a tarefa lembre-se de dar o Check!!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnMarcar22_Click(object sender, EventArgs e)
        {
            if (Timer22.Value.Hour < DateTime.Now.Hour || Timer22.Value.Minute < DateTime.Now.Minute || Timer22.Value.Second <= DateTime.Now.Second)
            {
                MessageBox.Show("Horario Inválido, Tente novamente!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                contador22.Start();
                Timer22.Enabled = false;
                btnMarcar22.Enabled = false;
                MessageBox.Show("Horário Marcado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show("Caso tenha concluido a tarefa lembre-se de dar o Check!!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnMarcar23_Click(object sender, EventArgs e)
        {
            if (Timer23.Value.Hour < DateTime.Now.Hour || Timer23.Value.Minute < DateTime.Now.Minute || Timer23.Value.Second <= DateTime.Now.Second)
            {
                MessageBox.Show("Horario Inválido, Tente novamente!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                contador23.Start();
                Timer23.Enabled = false;
                btnMarcar23.Enabled = false;
                MessageBox.Show("Horário Marcado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show("Caso tenha concluido a tarefa lembre-se de dar o Check!!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnMarcar24_Click(object sender, EventArgs e)
        {
            if (Timer24.Value.Hour < DateTime.Now.Hour || Timer24.Value.Minute < DateTime.Now.Minute || Timer24.Value.Second <= DateTime.Now.Second)
            {
                MessageBox.Show("Horario Inválido, Tente novamente!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                contador24.Start();
                Timer24.Enabled = false;
                btnMarcar24.Enabled = false;
                MessageBox.Show("Horário Marcado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show("Caso tenha concluido a tarefa lembre-se de dar o Check!!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnMarcar25_Click(object sender, EventArgs e)
        {
            if (Timer25.Value.Hour < DateTime.Now.Hour || Timer25.Value.Minute < DateTime.Now.Minute || Timer25.Value.Second <= DateTime.Now.Second)
            {
                MessageBox.Show("Horario Inválido, Tente novamente!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                contador25.Start();
                Timer25.Enabled = false;
                btnMarcar25.Enabled = false;
                MessageBox.Show("Horário Marcado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show("Caso tenha concluido a tarefa lembre-se de dar o Check!!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnMarcar26_Click(object sender, EventArgs e)
        {
            if (Timer26.Value.Hour < DateTime.Now.Hour || Timer26.Value.Minute < DateTime.Now.Minute || Timer26.Value.Second <= DateTime.Now.Second)
            {
                MessageBox.Show("Horario Inválido, Tente novamente!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                contador26.Start();
                Timer26.Enabled = false;
                btnMarcar26.Enabled = false;
                MessageBox.Show("Horário Marcado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show("Caso tenha concluido a tarefa lembre-se de dar o Check!!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnMarcar27_Click(object sender, EventArgs e)
        {
            if (Timer27.Value.Hour < DateTime.Now.Hour || Timer27.Value.Minute < DateTime.Now.Minute || Timer27.Value.Second <= DateTime.Now.Second)
            {
                MessageBox.Show("Horario Inválido, Tente novamente!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                contador27.Start();
                Timer27.Enabled = false;
                btnMarcar27.Enabled = false;
                MessageBox.Show("Horário Marcado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show("Caso tenha concluido a tarefa lembre-se de dar o Check!!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnMarcar28_Click(object sender, EventArgs e)
        {
            if (Timer28.Value.Hour < DateTime.Now.Hour || Timer28.Value.Minute < DateTime.Now.Minute || Timer28.Value.Second <= DateTime.Now.Second)
            {
                MessageBox.Show("Horario Inválido, Tente novamente!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                contador28.Start();
                Timer28.Enabled = false;
                btnMarcar28.Enabled = false;
                MessageBox.Show("Horário Marcado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show("Caso tenha concluido a tarefa lembre-se de dar o Check!!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnMarcar29_Click(object sender, EventArgs e)
        {
            if (Timer29.Value.Hour < DateTime.Now.Hour || Timer29.Value.Minute < DateTime.Now.Minute || Timer29.Value.Second <= DateTime.Now.Second)
            {
                MessageBox.Show("Horario Inválido, Tente novamente!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                contador29.Start();
                Timer29.Enabled = false;
                btnMarcar29.Enabled = false;
                MessageBox.Show("Horário Marcado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show("Caso tenha concluido a tarefa lembre-se de dar o Check!!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnMarcar30_Click(object sender, EventArgs e)
        {
            if (Timer30.Value.Hour < DateTime.Now.Hour || Timer30.Value.Minute < DateTime.Now.Minute || Timer30.Value.Second <= DateTime.Now.Second)
            {
                MessageBox.Show("Horario Inválido, Tente novamente!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                contador30.Start();
                Timer30.Enabled = false;
                btnMarcar30.Enabled = false;
                MessageBox.Show("Horário Marcado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show("Caso tenha concluido a tarefa lembre-se de dar o Check!!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnMarcar31_Click(object sender, EventArgs e)
        {
            if (Timer31.Value.Hour <= DateTime.Now.Hour || Timer31.Value.Minute <= DateTime.Now.Minute || Timer31.Value.Second <= DateTime.Now.Second)
            {
                MessageBox.Show("Horario Inválido, Tente novamente!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                contador31.Start();
                Timer31.Enabled = false;
                btnMarcar31.Enabled = false;
                MessageBox.Show("Horário Marcado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show("Caso tenha concluido a tarefa lembre-se de dar o Check!!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnMarcar32_Click(object sender, EventArgs e)
        {
            if (Timer32.Value.Hour < DateTime.Now.Hour || Timer32.Value.Minute < DateTime.Now.Minute || Timer32.Value.Second <= DateTime.Now.Second)
            {
                MessageBox.Show("Horario Inválido, Tente novamente!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                contador32.Start();
                Timer32.Enabled = false;
                btnMarcar32.Enabled = false;
                MessageBox.Show("Horário Marcado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show("Caso tenha concluido a tarefa lembre-se de dar o Check!!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnMarcar33_Click(object sender, EventArgs e)
        {
            if (Timer33.Value.Hour < DateTime.Now.Hour || Timer33.Value.Minute < DateTime.Now.Minute || Timer33.Value.Second <= DateTime.Now.Second)
            {
                MessageBox.Show("Horario Inválido, Tente novamente!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                contador33.Start();
                Timer33.Enabled = false;
                btnMarcar33.Enabled = false;
                MessageBox.Show("Horário Marcado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show("Caso tenha concluido a tarefa lembre-se de dar o Check!!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnMarcar34_Click(object sender, EventArgs e)
        {
            if (Timer34.Value.Hour < DateTime.Now.Hour || Timer34.Value.Minute < DateTime.Now.Minute || Timer34.Value.Second <= DateTime.Now.Second)
            {
                MessageBox.Show("Horario Inválido, Tente novamente!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                contador34.Start();
                Timer34.Enabled = false;
                btnMarcar34.Enabled = false;
                MessageBox.Show("Horário Marcado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show("Caso tenha concluido a tarefa lembre-se de dar o Check!!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        // função para contar o time
        public void CheckTime(object sender, System.Timers.ElapsedEventArgs e)
    {
        DateTime alarme = Timer1.Value;
        DateTime HoraAtual = DateTime.Now;

        if (HoraAtual.Hour == alarme.Hour && HoraAtual.Minute == alarme.Minute && HoraAtual.Second == alarme.Second)
        {
            MessageBox.Show("Hora de Fazer a Atividade Marcada!!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            AcoesAlarme();
        }

    }

    public void CheckTime2(object sender, System.Timers.ElapsedEventArgs e)
    {
        DateTime alarme = Timer2.Value;
        DateTime HoraAtual = DateTime.Now;

        if (HoraAtual.Hour == alarme.Hour && HoraAtual.Minute == alarme.Minute && HoraAtual.Second == alarme.Second)
        {
            MessageBox.Show("Hora de Fazer a Atividade Marcada!!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            AcoesAlarme2();
        }

    }

    

    public void CheckTime3(object sender, System.Timers.ElapsedEventArgs e)
    {
        DateTime alarme = Timer3.Value;
        DateTime HoraAtual = DateTime.Now;

        if (HoraAtual.Hour == alarme.Hour && HoraAtual.Minute == alarme.Minute && HoraAtual.Second == alarme.Second)
        {
            MessageBox.Show("Hora de Fazer a Atividade Marcada!!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            AcoesAlarme3();
        }

    }

    public void CheckTime4(object sender, System.Timers.ElapsedEventArgs e)
    {
        DateTime alarme = Timer4.Value;
        DateTime HoraAtual = DateTime.Now;

        if (HoraAtual.Hour == alarme.Hour && HoraAtual.Minute == alarme.Minute && HoraAtual.Second == alarme.Second)
        {
            MessageBox.Show("Hora de Fazer a Atividade Marcada!!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            AcoesAlarme4();
        }

    }

    public void CheckTime5(object sender, System.Timers.ElapsedEventArgs e)
    {
        DateTime alarme = Timer5.Value;
        DateTime HoraAtual = DateTime.Now;

        if (HoraAtual.Hour == alarme.Hour && HoraAtual.Minute == alarme.Minute && HoraAtual.Second == alarme.Second)
        {
            MessageBox.Show("Hora de Fazer a Atividade Marcada!!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            AcoesAlarme5();
        }

    }

    public void CheckTime6(object sender, System.Timers.ElapsedEventArgs e)
    {
        DateTime alarme = Timer6.Value;
        DateTime HoraAtual = DateTime.Now;

        if (HoraAtual.Hour == alarme.Hour && HoraAtual.Minute == alarme.Minute && HoraAtual.Second == alarme.Second)
        {
            MessageBox.Show("Hora de Fazer a Atividade Marcada!!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            AcoesAlarme6();
        }

    }

    public void CheckTime7(object sender, System.Timers.ElapsedEventArgs e)
    {
        DateTime alarme = Timer7.Value;
        DateTime HoraAtual = DateTime.Now;

        if (HoraAtual.Hour == alarme.Hour && HoraAtual.Minute == alarme.Minute && HoraAtual.Second == alarme.Second)
        {
            MessageBox.Show("Hora de Fazer a Atividade Marcada!!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            AcoesAlarme7();
        }

    }

    public void CheckTime8(object sender, System.Timers.ElapsedEventArgs e)
    {
        DateTime alarme = Timer8.Value;
        DateTime HoraAtual = DateTime.Now;

        if (HoraAtual.Hour == alarme.Hour && HoraAtual.Minute == alarme.Minute && HoraAtual.Second == alarme.Second)
        {
            MessageBox.Show("Hora de Fazer a Atividade Marcada!!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            AcoesAlarme8();
        }

    }

    public void CheckTime9(object sender, System.Timers.ElapsedEventArgs e)
    {
        DateTime alarme = Timer9.Value;
        DateTime HoraAtual = DateTime.Now;

        if (HoraAtual.Hour == alarme.Hour && HoraAtual.Minute == alarme.Minute && HoraAtual.Second == alarme.Second)
        {
            MessageBox.Show("Hora de Fazer a Atividade Marcada!!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            AcoesAlarme9();
        }

    }

    public void CheckTime10(object sender, System.Timers.ElapsedEventArgs e)
    {
        DateTime alarme = Timer10.Value;
        DateTime HoraAtual = DateTime.Now;

        if (HoraAtual.Hour == alarme.Hour && HoraAtual.Minute == alarme.Minute && HoraAtual.Second == alarme.Second)
        {
            MessageBox.Show("Hora de Fazer a Atividade Marcada!!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            AcoesAlarme10();
        }

    }

    public void CheckTime11(object sender, System.Timers.ElapsedEventArgs e)
    {
        DateTime alarme = Timer11.Value;
        DateTime HoraAtual = DateTime.Now;

        if (HoraAtual.Hour == alarme.Hour && HoraAtual.Minute == alarme.Minute && HoraAtual.Second == alarme.Second)
        {
            MessageBox.Show("Hora de Fazer a Atividade Marcada!!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            AcoesAlarme11();
        }

    }

    public void CheckTime12(object sender, System.Timers.ElapsedEventArgs e)
    {
        DateTime alarme = Timer12.Value;
        DateTime HoraAtual = DateTime.Now;

        if (HoraAtual.Hour == alarme.Hour && HoraAtual.Minute == alarme.Minute && HoraAtual.Second == alarme.Second)
        {
            MessageBox.Show("Hora de Fazer a Atividade Marcada!!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            AcoesAlarme12();
        }

    }

    public void CheckTime13(object sender, System.Timers.ElapsedEventArgs e)
    {
        DateTime alarme = Timer13.Value;
        DateTime HoraAtual = DateTime.Now;

        if (HoraAtual.Hour == alarme.Hour && HoraAtual.Minute == alarme.Minute && HoraAtual.Second == alarme.Second)
        {
            MessageBox.Show("Hora de Fazer a Atividade Marcada!!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            AcoesAlarme13();
        }

    }

    public void CheckTime14(object sender, System.Timers.ElapsedEventArgs e)
    {
        DateTime alarme = Timer14.Value;
        DateTime HoraAtual = DateTime.Now;

        if (HoraAtual.Hour == alarme.Hour && HoraAtual.Minute == alarme.Minute && HoraAtual.Second == alarme.Second)
        {
            MessageBox.Show("Hora de Fazer a Atividade Marcada!!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            AcoesAlarme14();
        }

    }

    public void CheckTime15(object sender, System.Timers.ElapsedEventArgs e)
    {
        DateTime alarme = Timer15.Value;
        DateTime HoraAtual = DateTime.Now;

        if (HoraAtual.Hour == alarme.Hour && HoraAtual.Minute == alarme.Minute && HoraAtual.Second == alarme.Second)
        {
            MessageBox.Show("THora de Fazer a Atividade Marcada!!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            AcoesAlarme15();
        }

    }

    public void CheckTime16(object sender, System.Timers.ElapsedEventArgs e)
    {
        DateTime alarme = Timer16.Value;
        DateTime HoraAtual = DateTime.Now;

        if (HoraAtual.Hour == alarme.Hour && HoraAtual.Minute == alarme.Minute && HoraAtual.Second == alarme.Second)
        {
            MessageBox.Show("Hora de Fazer a Atividade Marcada!!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            AcoesAlarme16();
        }

    }

    public void CheckTime17(object sender, System.Timers.ElapsedEventArgs e)
    {
        DateTime alarme = Timer17.Value;
        DateTime HoraAtual = DateTime.Now;

        if (HoraAtual.Hour == alarme.Hour && HoraAtual.Minute == alarme.Minute && HoraAtual.Second == alarme.Second)
        {
            MessageBox.Show("Hora de Fazer a Atividade Marcada!!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            AcoesAlarme17();
        }

    }

    public void CheckTime18(object sender, System.Timers.ElapsedEventArgs e)
    {
        DateTime alarme = Timer18.Value;
        DateTime HoraAtual = DateTime.Now;

        if (HoraAtual.Hour == alarme.Hour && HoraAtual.Minute == alarme.Minute && HoraAtual.Second == alarme.Second)
        {
            MessageBox.Show("Hora de Fazer a Atividade Marcada!!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            AcoesAlarme18();
        }

    }

    public void CheckTime19(object sender, System.Timers.ElapsedEventArgs e)
    {
        DateTime alarme = Timer19.Value;
        DateTime HoraAtual = DateTime.Now;

        if (HoraAtual.Hour == alarme.Hour && HoraAtual.Minute == alarme.Minute && HoraAtual.Second == alarme.Second)
        {
            MessageBox.Show("Hora de Fazer a Atividade Marcada!!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            AcoesAlarme19();
        }

    }

    public void CheckTime20(object sender, System.Timers.ElapsedEventArgs e)
    {
        DateTime alarme = Timer20.Value;
        DateTime HoraAtual = DateTime.Now;

        if (HoraAtual.Hour == alarme.Hour && HoraAtual.Minute == alarme.Minute && HoraAtual.Second == alarme.Second)
        {
            MessageBox.Show("Tarefa não finalizada!!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            AcoesAlarme20();
        }

    }

    public void CheckTime21(object sender, System.Timers.ElapsedEventArgs e)
    {
        DateTime alarme = Timer21.Value;
        DateTime HoraAtual = DateTime.Now;

        if (HoraAtual.Hour == alarme.Hour && HoraAtual.Minute == alarme.Minute && HoraAtual.Second == alarme.Second)
        {
            MessageBox.Show("Hora de Fazer a Atividade Marcada!!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            AcoesAlarme21();
        }

    }

    public void CheckTime22(object sender, System.Timers.ElapsedEventArgs e)
    {
        DateTime alarme = Timer22.Value;
        DateTime HoraAtual = DateTime.Now;

        if (HoraAtual.Hour == alarme.Hour && HoraAtual.Minute == alarme.Minute && HoraAtual.Second == alarme.Second)
        {
            MessageBox.Show("Hora de Fazer a Atividade Marcada!!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            AcoesAlarme22();
        }

    }

    public void CheckTime23(object sender, System.Timers.ElapsedEventArgs e)
    {
        DateTime alarme = Timer23.Value;
        DateTime HoraAtual = DateTime.Now;

        if (HoraAtual.Hour == alarme.Hour && HoraAtual.Minute == alarme.Minute && HoraAtual.Second == alarme.Second)
        {
            MessageBox.Show("Hora de Fazer a Atividade Marcada!!!!Tarefa não finalizada!!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            AcoesAlarme23();
        }

    }

    public void CheckTime24(object sender, System.Timers.ElapsedEventArgs e)
    {
        DateTime alarme = Timer24.Value;
        DateTime HoraAtual = DateTime.Now;

        if (HoraAtual.Hour == alarme.Hour && HoraAtual.Minute == alarme.Minute && HoraAtual.Second == alarme.Second)
        {
            MessageBox.Show("Hora de Fazer a Atividade Marcada!!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            AcoesAlarme24();
        }

    }

    public void CheckTime25(object sender, System.Timers.ElapsedEventArgs e)
    {
        DateTime alarme = Timer25.Value;
        DateTime HoraAtual = DateTime.Now;

        if (HoraAtual.Hour == alarme.Hour && HoraAtual.Minute == alarme.Minute && HoraAtual.Second == alarme.Second)
        {
            MessageBox.Show("Hora de Fazer a Atividade Marcada!!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            AcoesAlarme25();
        }

    }

    public void CheckTime26(object sender, System.Timers.ElapsedEventArgs e)
    {
        DateTime alarme = Timer26.Value;
        DateTime HoraAtual = DateTime.Now;

        if (HoraAtual.Hour == alarme.Hour && HoraAtual.Minute == alarme.Minute && HoraAtual.Second == alarme.Second)
        {
            MessageBox.Show("Hora de Fazer a Atividade Marcada!!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            AcoesAlarme26();
        }

    }

    public void CheckTime27(object sender, System.Timers.ElapsedEventArgs e)
    {
        DateTime alarme = Timer27.Value;
        DateTime HoraAtual = DateTime.Now;

        if (HoraAtual.Hour == alarme.Hour && HoraAtual.Minute == alarme.Minute && HoraAtual.Second == alarme.Second)
        {
            MessageBox.Show("Hora de Fazer a Atividade Marcada!!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            AcoesAlarme27();
        }

    }

    public void CheckTime28(object sender, System.Timers.ElapsedEventArgs e)
    {
        DateTime alarme = Timer28.Value;
        DateTime HoraAtual = DateTime.Now;

        if (HoraAtual.Hour == alarme.Hour && HoraAtual.Minute == alarme.Minute && HoraAtual.Second == alarme.Second)
        {
            MessageBox.Show("Hora de Fazer a Atividade Marcada!!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            AcoesAlarme28();
        }

    }

    public void CheckTime29(object sender, System.Timers.ElapsedEventArgs e)
    {
        DateTime alarme = Timer29.Value;
        DateTime HoraAtual = DateTime.Now;

        if (HoraAtual.Hour == alarme.Hour && HoraAtual.Minute == alarme.Minute && HoraAtual.Second == alarme.Second)
        {
            MessageBox.Show("Hora de Fazer a Atividade Marcada!!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            AcoesAlarme29();
        }

    }

    public void CheckTime30(object sender, System.Timers.ElapsedEventArgs e)
    {
        DateTime alarme = Timer30.Value;
        DateTime HoraAtual = DateTime.Now;

        if (HoraAtual.Hour == alarme.Hour && HoraAtual.Minute == alarme.Minute && HoraAtual.Second == alarme.Second)
        {
            MessageBox.Show("Hora de Fazer a Atividade Marcada!!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            AcoesAlarme30();
        }

    }

    public void CheckTime31(object sender, System.Timers.ElapsedEventArgs e)
    {
        DateTime alarme = Timer31.Value;
        DateTime HoraAtual = DateTime.Now;

        if (HoraAtual.Hour == alarme.Hour && HoraAtual.Minute == alarme.Minute && HoraAtual.Second == alarme.Second)
        {
            MessageBox.Show("Hora de Fazer a Atividade Marcada!!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            AcoesAlarme31();
        }

    }

    public void CheckTime32(object sender, System.Timers.ElapsedEventArgs e)
    {
        DateTime alarme = Timer32.Value;
        DateTime HoraAtual = DateTime.Now;

        if (HoraAtual.Hour == alarme.Hour && HoraAtual.Minute == alarme.Minute && HoraAtual.Second == alarme.Second)
        {
            MessageBox.Show("Hora de Fazer a Atividade Marcada!!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            AcoesAlarme32();
        }

    }

    public void CheckTime33(object sender, System.Timers.ElapsedEventArgs e)
    {
        DateTime alarme = Timer33.Value;
        DateTime HoraAtual = DateTime.Now;

        if (HoraAtual.Hour == alarme.Hour && HoraAtual.Minute == alarme.Minute && HoraAtual.Second == alarme.Second)
        {
            MessageBox.Show("Hora de Fazer a Atividade Marcada!!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            AcoesAlarme33();
        }

    }

    public void CheckTime34(object sender, System.Timers.ElapsedEventArgs e)
    {
        DateTime alarme = Timer34.Value;
        DateTime HoraAtual = DateTime.Now;

        if (HoraAtual.Hour == alarme.Hour && HoraAtual.Minute == alarme.Minute && HoraAtual.Second == alarme.Second)
        {
            MessageBox.Show("Hora de Fazer a Atividade Marcada!!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            AcoesAlarme34();
        }


    }

    

    //FUNCAO PARA AS ACOES POS ALARME

    public void AcoesAlarme()
    {
        Nota0.BackColor = Color.Firebrick;
        contador.Stop();
    }
    public void AcoesAlarme2()
    {
        Nota2.BackColor = Color.Firebrick;
        contador2.Stop();
    }
    public void AcoesAlarme3()
    {
            Nota3.BackColor = Color.Firebrick;
            contador3.Stop();
    }
        public void AcoesAlarme4()
        {
            Nota4.BackColor = Color.Firebrick;
            contador4.Stop();
        }
        public void AcoesAlarme5()
        {
            Nota5.BackColor = Color.Firebrick;
            contador5.Stop();
        }
        public void AcoesAlarme6()
        {
            Nota6.BackColor = Color.Firebrick;
            contador6.Stop();
        }
        public void AcoesAlarme7()
        {
            Nota7.BackColor = Color.Firebrick;
            contador7.Stop();
        }
        public void AcoesAlarme8()
        {
            Nota8.BackColor = Color.Firebrick;
            contador8.Stop();
        }
        public void AcoesAlarme9()
        {
            Nota9.BackColor = Color.Firebrick;
            contador9.Stop();
        }
        public void AcoesAlarme10()
        {
            Nota10.BackColor = Color.Firebrick;
            contador10.Stop();
        }
        public void AcoesAlarme11()
        {
            Nota11.BackColor = Color.Firebrick;
            contador11.Stop();
        }
        public void AcoesAlarme12()
        {
            Nota12.BackColor = Color.Firebrick;
            contador12.Stop();
        }
        public void AcoesAlarme13()
        {
            Nota13.BackColor = Color.Firebrick;
            contador13.Stop();
        }
        public void AcoesAlarme14()
        {
            Nota14.BackColor = Color.Firebrick;
            contador14.Stop();
        }
        public void AcoesAlarme15()
        {
            Nota15.BackColor = Color.Firebrick;
            contador15.Stop();
        }
        public void AcoesAlarme16()
        {
            Nota16.BackColor = Color.Firebrick;
            contador16.Stop();
        }
        public void AcoesAlarme17()
        {
            Nota17.BackColor = Color.Firebrick;
            contador17.Stop();
        }
        public void AcoesAlarme18()
        {
            Nota18.BackColor = Color.Firebrick;
            contador18.Stop();
        }
        public void AcoesAlarme19()
        {
            Nota19.BackColor = Color.Firebrick;
            contador19.Stop();
        }
        public void AcoesAlarme20()
        {
            Nota20.BackColor = Color.Firebrick;
            contador20.Stop();
        }
        public void AcoesAlarme21()
        {
            Nota21.BackColor = Color.Firebrick;
            contador21.Stop();
        }
        public void AcoesAlarme22()
        {
            Nota22.BackColor = Color.Firebrick;
            contador22.Stop();
        }
        public void AcoesAlarme23()
        {
            Nota23.BackColor = Color.Firebrick;
            contador23.Stop();
        }
        public void AcoesAlarme24()
        {
            Nota24.BackColor = Color.Firebrick;
            contador24.Stop();
        }

        public void AcoesAlarme25()
        {
            Nota25.BackColor = Color.Firebrick;
            contador25.Stop();
        }
        public void AcoesAlarme26()
        {
            Nota26.BackColor = Color.Firebrick;
            contador26.Stop();
        }
        public void AcoesAlarme27()
        {
            Nota27.BackColor = Color.Firebrick;
            contador27.Stop();
        }
        public void AcoesAlarme28()
        {
            Nota28.BackColor = Color.Firebrick;
            contador28.Stop();
        }
        public void AcoesAlarme29()
        {
            Nota29.BackColor = Color.Firebrick;
            contador29.Stop();
        }
        public void AcoesAlarme30()
        {
            Nota30.BackColor = Color.Firebrick;
            contador30.Stop();
        }
        public void AcoesAlarme31()
        {
            Nota31.BackColor = Color.Firebrick;
            contador31.Stop();
        }
        public void AcoesAlarme32()
        {
            Nota32.BackColor = Color.Firebrick;
            contador32.Stop();
        }
        public void AcoesAlarme33()
        {
            Nota33.BackColor = Color.Firebrick;
            contador33.Stop();
        }
        public void AcoesAlarme34()
        {
            Nota34.BackColor = Color.Firebrick;
            contador34 .Stop();
        }


        // FUNCAO QUE MUDA A COR PARA PROCESSO DE AMARELO

        private void Timer1_EnabledChanged(object sender, EventArgs e)
    {
        Nota0.BackColor = Color.Yellow;
    }

     void Timer2_EnabledChanged(object sender, EventArgs e)
     {
            Nota2.BackColor = Color.Yellow;
     }

        private void Timer3_EnabledChanged(object sender, EventArgs e)
        {
            Nota3.BackColor = Color.Yellow;
        }
        private void Timer4_EnabledChanged(object sender, EventArgs e)
        {
            Nota4.BackColor = Color.Yellow;
        }
        private void Timer5_EnabledChanged(object sender, EventArgs e)
        {
            Nota5.BackColor = Color.Yellow;
        }
        private void Timer6_EnabledChanged(object sender, EventArgs e)
        {
            Nota6.BackColor = Color.Yellow;
        }
        private void Timer7_EnabledChanged(object sender, EventArgs e)
        {
            Nota7.BackColor = Color.Yellow;
        }
        private void Timer8_EnabledChanged(object sender, EventArgs e)
        {
            Nota8.BackColor = Color.Yellow;
        }
        private void Timer9_EnabledChanged(object sender, EventArgs e)
        {
            Nota9.BackColor = Color.Yellow;
        }
        private void Timer10_EnabledChanged(object sender, EventArgs e)
        {
            Nota10.BackColor = Color.Yellow;
        }
        private void Timer11_EnabledChanged(object sender, EventArgs e)
        {
            Nota11.BackColor = Color.Yellow;
        }
        private void Timer12_EnabledChanged(object sender, EventArgs e)
        {
            Nota12.BackColor = Color.Yellow;
        }
        private void Timer13_EnabledChanged(object sender, EventArgs e)
        {
            Nota13.BackColor = Color.Yellow;
        }
        private void Timer14_EnabledChanged(object sender, EventArgs e)
        {
            Nota14.BackColor = Color.Yellow;
        }
        private void Timer15_EnabledChanged(object sender, EventArgs e)
        {
            Nota15.BackColor = Color.Yellow;
        }
        private void Timer16_EnabledChanged(object sender, EventArgs e)
        {
            Nota16.BackColor = Color.Yellow;
        }
        private void Timer17_EnabledChanged(object sender, EventArgs e)
        {
            Nota17.BackColor = Color.Yellow;
        }

        private void Timer18_EnabledChanged(object sender, EventArgs e)
        {
            Nota18.BackColor = Color.Yellow;
        }
        private void Timer19_EnabledChanged(object sender, EventArgs e)
        {
            Nota19.BackColor = Color.Yellow;
        }
        private void Timer20_EnabledChanged(object sender, EventArgs e)
        {
            Nota20.BackColor = Color.Yellow;
        }
        private void Timer21_EnabledChanged(object sender, EventArgs e)
        {
            Nota21.BackColor = Color.Yellow;
        }
        private void Timer22_EnabledChanged(object sender, EventArgs e)
        {
            Nota22.BackColor = Color.Yellow;
        }
        private void Timer23_EnabledChanged(object sender, EventArgs e)
        {
            Nota23.BackColor = Color.Yellow;
        }
        private void Timer24_EnabledChanged(object sender, EventArgs e)
        {
            Nota24.BackColor = Color.Yellow;
        }
        private void Timer25_EnabledChanged(object sender, EventArgs e)
        {
            Nota25.BackColor = Color.Yellow;
        }
        private void Timer26_EnabledChanged(object sender, EventArgs e)
        {
            Nota26.BackColor = Color.Yellow;
        }
        private void Timer27_EnabledChanged(object sender, EventArgs e)
        {
            Nota27.BackColor = Color.Yellow;
        }
        private void Timer28_EnabledChanged(object sender, EventArgs e)
        {
            Nota28.BackColor = Color.Yellow;
        }
        private void Timer29_EnabledChanged(object sender, EventArgs e)
        {
            Nota29.BackColor = Color.Yellow;
        }
        private void Timer30_EnabledChanged(object sender, EventArgs e)
        {
            Nota30.BackColor = Color.Yellow;
        }
        private void Timer31_EnabledChanged(object sender, EventArgs e)
        {
            Nota31.BackColor = Color.Yellow;
        }
        private void Timer32_EnabledChanged(object sender, EventArgs e)
        {
            Nota32.BackColor = Color.Yellow;
        }
        private void Timer33_EnabledChanged(object sender, EventArgs e)
        {
            Nota33.BackColor = Color.Yellow;
        }
        private void Timer34_EnabledChanged(object sender, EventArgs e)
        {
            Nota34.BackColor = Color.Yellow;
        }

       
    }
    

}
