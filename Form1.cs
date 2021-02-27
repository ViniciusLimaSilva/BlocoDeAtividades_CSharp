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

namespace Notas
{
    public partial class Notas : Form
    {
        public Notas()
        {
            InitializeComponent();
        }

        public void MarcaCheckBox(TextBox Nota, Button buttonExcluir, CheckBox checknota)
        {
            if (checknota.CheckState == CheckState.Checked)
            {


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


                }
            }

        }

        public void AcoesButtonAdd(TextBox nota, Button buttonExcluir, CheckBox checknota)
        {
            nota.Visible = true;
            buttonExcluir.Visible = true;
            checknota.Visible = true;
            nota.BackColor = Color.Orange;
        }
        
        public void AcoesButtonRemove(TextBox nota, Button buttonExcluir, CheckBox checknota)
        {
            nota.Text = "";
            nota.Visible = false;
            buttonExcluir.Visible = false;
            checknota.CheckState = CheckState.Unchecked;
            checknota.Visible = false;
        }

        public void VerificaVazio()
        {
            if (Nota0.Text != "")
            {
                Nota0.Visible = true;
                buttonExcluirStart.Visible = true;
                checknota1.Visible = true;
            }

            if (Nota2.Text != "")
            {
                Nota2.Visible = true;
                buttonExcluir2.Visible = true;
                checknota2.Visible = true;
            }
            if (Nota3.Text != "")
            {
                Nota3.Visible = true;
                buttonExcluir3.Visible = true;
                checknota3.Visible = true;
            }
            if (Nota4.Text != "")
            {
                Nota4.Visible = true;
                buttonExcluir4.Visible = true;
                checknota4.Visible = true;
            }
            if (Nota5.Text != "")
            {
                Nota5.Visible = true;
                buttonExcluir5.Visible = true;
                checknota5.Visible = true;
            }
            if (Nota6.Text != "")
            {
                Nota6.Visible = true;
                buttonExcluir6.Visible = true;
                checknota6.Visible = true;
            }
            if (Nota7.Text != "")
            {
                Nota7.Visible = true;
                buttonExcluir7.Visible = true;
                checknota7.Visible = true;
            }
            if (Nota8.Text != "")
            {
                Nota8.Visible = true;
                buttonExcluir8.Visible = true;
                checknota8.Visible = true;
            }
            if (Nota9.Text != "")
            {
                Nota9.Visible = true;
                buttonExcluir9.Visible = true;
                checknota9.Visible = true;
            }
            if (Nota10.Text != "")
            {
                Nota10.Visible = true;
                buttonExcluir10.Visible = true;
                checknota10.Visible = true;
            }
            if (Nota11.Text != "")
            {
                Nota11.Visible = true;
                buttonExcluir11.Visible = true;
            }
            if (Nota12.Text != "")
            {
                Nota12.Visible = true;
                buttonExcluir12.Visible = true;
                checknota12.Visible = true;
            }
            if (Nota13.Text != "")
            {
                Nota13.Visible = true;
                buttonExcluir13.Visible = true;
                checknota13.Visible = true;
            }
            if (Nota14.Text != "")
            {
                Nota14.Visible = true;
                buttonExcluir14.Visible = true;
                checknota14.Visible = true;
            }
            if (Nota15.Text != "")
            {
                Nota15.Visible = true;
                buttonExcluir15.Visible = true;
                checknota15.Visible = true;
            }
            if (Nota16.Text != "")
            {
                Nota16.Visible = true;
                buttonExcluir16.Visible = true;
                checknota16.Visible = true;
            }
            if (Nota17.Text != "")
            {
                Nota17.Visible = true;
                buttonExcluir17.Visible = true;
                checknota17.Visible = true;
            }
            if (Nota18.Text != "")
            {
                Nota18.Visible = true;
                buttonExcluir18.Visible = true;
                checknota18.Visible = true;
            }
            if (Nota19.Text != "")
            {
                Nota19.Visible = true;
                buttonExcluir19.Visible = true;
                checknota19.Visible = true;
            }
            if (Nota20.Text != "")
            {
                Nota20.Visible = true;
                buttonExcluir20.Visible = true;
                checknota20.Visible = true;
            }
            if (Nota21.Text != "")
            {
                Nota21.Visible = true;
                buttonExcluir21.Visible = true;
                checknota21.Visible = true;
            }
            if (Nota22.Text != "")
            {
                Nota22.Visible = true;
                buttonExcluir22.Visible = true;
                checknota22.Visible = true;
            }
            if (Nota23.Text != "")
            {
                Nota23.Visible = true;
                buttonExcluir23.Visible = true;
                checknota23.Visible = true;
            }
            if (Nota24.Text != "")
            {
                Nota24.Visible = true;
                buttonExcluir24.Visible = true;
                checknota24.Visible = true;
            }
            if (Nota25.Text != "")
            {
                Nota25.Visible = true;
                buttonExcluir25.Visible = true;
                checknota25.Visible = true;
            }
            if (Nota26.Text != "")
            {
                Nota26.Visible = true;
                buttonExcluir26.Visible = true;
                checknota26.Visible = true;
            }
            if (Nota27.Text != "")
            {
                Nota27.Visible = true;
                buttonExcluir27.Visible = true;
                checknota27.Visible = true;
            }
            if (Nota28.Text != "")
            {
                Nota28.Visible = true;
                buttonExcluir28.Visible = true;
                checknota28.Visible = true;
            }
            if (Nota29.Text != "")
            {
                Nota29.Visible = true;
                buttonExcluir29.Visible = true;
                checknota29.Visible = true;
            }
            if (Nota30.Text != "")
            {
                Nota30.Visible = true;
                buttonExcluir30.Visible = true;
                checknota30.Visible = true;
            }
            if (Nota31.Text != "")
            {
                Nota31.Visible = true;
                buttonExcluir31.Visible = true;
                checknota31.Visible = true;
            }
            if (Nota32.Text != "")
            {
                Nota32.Visible = true;
                buttonExcluir32.Visible = true;
                checknota32.Visible = true;
            }
            if (Nota33.Text != "")
            {
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
            string Arquivo10= "Nota10.txt";
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
                fluxoTexto28= new StreamReader("Nota28.txt");
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

            // usado para tirar o X padrão do formulario
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);

            ler_texto_salvo();

            VerificaVazio();


        }


       
        // botões de alerta
        private void btnAlerta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para adicionar uma Nota clique no Botão esquerdo abaixo!!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAlerta2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para remover uma Nota clique no Botão direito abaixo!!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAlerta3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para marcar uma Atividade como concluida clique no Botão de check à direita da nota!!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        //botões de ADD


        private void buttonStart_Click(object sender, EventArgs e)
        {

            AcoesButtonAdd(Nota0, buttonExcluirStart, checknota1);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AcoesButtonAdd(Nota2, buttonExcluir2, checknota2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AcoesButtonAdd(Nota3, buttonExcluir3, checknota3);
        }      

        private void button4_Click(object sender, EventArgs e)
        {
            AcoesButtonAdd(Nota4, buttonExcluir4, checknota4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AcoesButtonAdd(Nota5, buttonExcluir5, checknota5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AcoesButtonAdd(Nota6, buttonExcluir6, checknota6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AcoesButtonAdd(Nota7, buttonExcluir7, checknota7);

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            AcoesButtonAdd(Nota8, buttonExcluir8, checknota8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AcoesButtonAdd(Nota9, buttonExcluir9, checknota9);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            AcoesButtonAdd(Nota10, buttonExcluir10, checknota10);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            AcoesButtonAdd(Nota11, buttonExcluir11, checknota11);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            AcoesButtonAdd(Nota12, buttonExcluir12, checknota12);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            AcoesButtonAdd(Nota13, buttonExcluir13, checknota13);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            AcoesButtonAdd(Nota14, buttonExcluir14, checknota14);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            AcoesButtonAdd(Nota15, buttonExcluir15, checknota15);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            AcoesButtonAdd(Nota16, buttonExcluir16, checknota16);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            AcoesButtonAdd(Nota17, buttonExcluir17, checknota17);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            AcoesButtonAdd(Nota18, buttonExcluir18, checknota18);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            AcoesButtonAdd(Nota19, buttonExcluir19, checknota19);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            AcoesButtonAdd(Nota20, buttonExcluir20, checknota20);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            AcoesButtonAdd(Nota21, buttonExcluir21, checknota21);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            AcoesButtonAdd(Nota22, buttonExcluir22, checknota22);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            AcoesButtonAdd(Nota23, buttonExcluir23, checknota23);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            AcoesButtonAdd(Nota24, buttonExcluir24, checknota24);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            AcoesButtonAdd(Nota25, buttonExcluir25, checknota25);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            AcoesButtonAdd(Nota26, buttonExcluir26, checknota26);

        }

        private void button27_Click(object sender, EventArgs e)
        {
            AcoesButtonAdd(Nota27, buttonExcluir27, checknota27);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            AcoesButtonAdd(Nota28, buttonExcluir28, checknota28);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            AcoesButtonAdd(Nota29, buttonExcluir29, checknota29);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            AcoesButtonAdd(Nota30, buttonExcluir30, checknota30);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            AcoesButtonAdd(Nota31, buttonExcluir31, checknota31);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            AcoesButtonAdd(Nota32, buttonExcluir32, checknota32);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            AcoesButtonAdd(Nota33, buttonExcluir33, checknota33);

        }

        private void button34_Click(object sender, EventArgs e)
        {
            AcoesButtonAdd(Nota34, buttonExcluir34, checknota34);
        }

       

       // Botões de Exclusão

      

        private void buttonExcluirStart_Click(object sender, EventArgs e)
        {

            AcoesButtonRemove(Nota0, buttonExcluirStart, checknota1);


        }

        private void buttonExcluir2_Click(object sender, EventArgs e)
        {
            AcoesButtonRemove(Nota2, buttonExcluir2, checknota2);

        }

        private void buttonExcluir3_Click(object sender, EventArgs e)
        {

            AcoesButtonRemove(Nota3, buttonExcluir3, checknota3);

        }

        private void buttonExcluir4_Click(object sender, EventArgs e)
        {
            AcoesButtonRemove(Nota4, buttonExcluir4, checknota4);

        }

        private void buttonExcluir5_Click(object sender, EventArgs e)
        {
            AcoesButtonRemove(Nota5, buttonExcluir5, checknota5);

        }

        private void buttonExcluir6_Click(object sender, EventArgs e)
        {

            AcoesButtonRemove(Nota6, buttonExcluir6, checknota6);

        }

        private void buttonExcluir7_Click(object sender, EventArgs e)
        {
            AcoesButtonRemove(Nota7, buttonExcluir7, checknota7);

        }

        private void buttonExcluir8_Click(object sender, EventArgs e)
        {

            AcoesButtonRemove(Nota8, buttonExcluir8, checknota8);

        }

        private void buttonExcluir9_Click(object sender, EventArgs e)
        {

            AcoesButtonRemove(Nota9, buttonExcluir9, checknota9);

        }

        private void buttonExcluir10_Click(object sender, EventArgs e)
        {
            AcoesButtonRemove(Nota10, buttonExcluir10, checknota10);

        }

        private void buttonExcluir11_Click(object sender, EventArgs e)
        {
            AcoesButtonRemove(Nota11, buttonExcluir11, checknota11);

        }

        private void buttonExcluir12_Click(object sender, EventArgs e)
        {
            AcoesButtonRemove(Nota12, buttonExcluir12, checknota12);
            
        }

        private void buttonExcluir13_Click(object sender, EventArgs e)
        {
            AcoesButtonRemove(Nota13, buttonExcluir13, checknota13);
        }

        private void buttonExcluir14_Click(object sender, EventArgs e)
        {
            AcoesButtonRemove(Nota14, buttonExcluir14, checknota14);
        }

        private void buttonExcluir15_Click(object sender, EventArgs e)
        {
            AcoesButtonRemove(Nota15, buttonExcluir15, checknota15);
        }

        private void buttonExcluir16_Click(object sender, EventArgs e)
        {
            AcoesButtonRemove(Nota16, buttonExcluir16, checknota16);

        }

        private void buttonExcluir17_Click(object sender, EventArgs e)
        {

            AcoesButtonRemove(Nota17, buttonExcluir17, checknota17);

        }

        private void buttonExcluir18_Click(object sender, EventArgs e)
        {
            AcoesButtonRemove(Nota18, buttonExcluir18, checknota18);
        }

        private void buttonExcluir19_Click(object sender, EventArgs e)
        {
            AcoesButtonRemove(Nota19, buttonExcluir19, checknota19);
        }

        private void buttonExcluir20_Click(object sender, EventArgs e)
        {
            AcoesButtonRemove(Nota20, buttonExcluir20, checknota20);

        }

        private void buttonExcluir21_Click(object sender, EventArgs e)
        {
            AcoesButtonRemove(Nota21, buttonExcluir21, checknota21);

        }

        private void buttonExcluir22_Click(object sender, EventArgs e)
        {
            AcoesButtonRemove(Nota22, buttonExcluir22, checknota22);
        }

        private void buttonExcluir23_Click(object sender, EventArgs e)
        {
            AcoesButtonRemove(Nota23, buttonExcluir23, checknota23);
        }

        private void buttonExcluir24_Click(object sender, EventArgs e)
        {
            AcoesButtonRemove(Nota24, buttonExcluir24, checknota24);
        }

        private void buttonExcluir25_Click(object sender, EventArgs e)
        {
            AcoesButtonRemove(Nota25, buttonExcluir25, checknota25);
        }

        private void buttonExcluir26_Click(object sender, EventArgs e)
        {
            AcoesButtonRemove(Nota26, buttonExcluir26, checknota26);
        }

        private void buttonExcluir27_Click(object sender, EventArgs e)
        {
            AcoesButtonRemove(Nota27, buttonExcluir27, checknota27);
        }

        private void buttonExcluir28_Click(object sender, EventArgs e)
        {
            AcoesButtonRemove(Nota28, buttonExcluir28, checknota28);
        }

        private void buttonExcluir29_Click(object sender, EventArgs e)
        {
            AcoesButtonRemove(Nota29, buttonExcluir29, checknota29);
        }

        private void buttonExcluir30_Click(object sender, EventArgs e)
        {
            AcoesButtonRemove(Nota30, buttonExcluir30, checknota30);
        }

        private void buttonExcluir31_Click(object sender, EventArgs e)
        {
            AcoesButtonRemove(Nota31, buttonExcluir31, checknota31);
        }

        private void buttonExcluir32_Click(object sender, EventArgs e)
        {
            AcoesButtonRemove(Nota32, buttonExcluir32, checknota32);
        }

        private void buttonExcluir33_Click(object sender, EventArgs e)
        {
            AcoesButtonRemove(Nota33, buttonExcluir33, checknota33);
        }

        private void buttonExcluir34_Click(object sender, EventArgs e)
        {
            AcoesButtonRemove(Nota34, buttonExcluir34, checknota34);
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

        private void Nota0_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nota2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nota0_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Nota19_TextChanged(object sender, EventArgs e)
        {

        }

             // Botões para check de conclusão das atividades

        private void checknota1_CheckedChanged(object sender, EventArgs e)
        {
            MarcaCheckBox(Nota0, buttonExcluirStart, checknota1);
        }
           
        private void checknota2_CheckedChanged(object sender, EventArgs e)
        {
            MarcaCheckBox(Nota2, buttonExcluir2, checknota2);
        }      

        private void checknota3_CheckedChanged(object sender, EventArgs e)
        {
            MarcaCheckBox(Nota3, buttonExcluir3, checknota3);
        }

        private void checknota4_CheckedChanged(object sender, EventArgs e)
        {
            MarcaCheckBox(Nota4, buttonExcluir4, checknota4);
        }

        private void checknota5_CheckedChanged(object sender, EventArgs e)
        {
            MarcaCheckBox(Nota5, buttonExcluir5, checknota5);
        }

        private void checknota6_CheckedChanged(object sender, EventArgs e)
        {
            MarcaCheckBox(Nota6, buttonExcluir6, checknota6);
        }

        private void checknota7_CheckedChanged(object sender, EventArgs e)
        {
            MarcaCheckBox(Nota7, buttonExcluir7, checknota7);
        }

        private void checknota8_CheckedChanged(object sender, EventArgs e)
        {
            MarcaCheckBox(Nota8, buttonExcluir8, checknota8);
        }

        private void checknota9_CheckedChanged(object sender, EventArgs e)
        {
            MarcaCheckBox(Nota9, buttonExcluir9, checknota9);
        }

        private void checknota10_CheckedChanged(object sender, EventArgs e)
        {
            MarcaCheckBox(Nota10, buttonExcluir10, checknota10);
        }

        private void checknota11_CheckedChanged(object sender, EventArgs e)
        {
            MarcaCheckBox(Nota11, buttonExcluir11, checknota11);
        }

        private void checknota12_CheckedChanged(object sender, EventArgs e)
        {
            MarcaCheckBox(Nota12, buttonExcluir12, checknota12);
        }

        private void checknota13_CheckedChanged(object sender, EventArgs e)
        {
            MarcaCheckBox(Nota13, buttonExcluir13, checknota13);
        }

        private void checknota14_CheckedChanged(object sender, EventArgs e)
        {
            MarcaCheckBox(Nota14, buttonExcluir14, checknota14);
        }

        private void checknota15_CheckedChanged(object sender, EventArgs e)
        {
            MarcaCheckBox(Nota15, buttonExcluir15, checknota15);
        }

        private void checknota16_CheckedChanged(object sender, EventArgs e)
        {
            MarcaCheckBox(Nota16, buttonExcluir16, checknota16);
        }

        private void checknota17_CheckedChanged(object sender, EventArgs e)
        {
            MarcaCheckBox(Nota17, buttonExcluir17, checknota17);
        }

        private void checknota18_CheckedChanged(object sender, EventArgs e)
        {
            MarcaCheckBox(Nota18, buttonExcluir18, checknota18);
        }

        private void checknota19_CheckedChanged(object sender, EventArgs e)
        {
            MarcaCheckBox(Nota19, buttonExcluir19, checknota19);
        }

        private void checknota20_CheckedChanged(object sender, EventArgs e)
        {
            MarcaCheckBox(Nota20, buttonExcluir20, checknota20);
        }

        private void checknota21_CheckedChanged(object sender, EventArgs e)
        {
            MarcaCheckBox(Nota21, buttonExcluir21, checknota21);
        }

        private void checknota22_CheckedChanged(object sender, EventArgs e)
        {
            MarcaCheckBox(Nota22, buttonExcluir22, checknota22);
        }

        private void checknota23_CheckedChanged(object sender, EventArgs e)
        {
            MarcaCheckBox(Nota23, buttonExcluir23, checknota23);
        }

        private void checknota24_CheckedChanged(object sender, EventArgs e)
        {
            MarcaCheckBox(Nota24, buttonExcluir24, checknota24);
        }

        private void checknota25_CheckedChanged(object sender, EventArgs e)
        {
            MarcaCheckBox(Nota25, buttonExcluir25, checknota25);
        }

        private void checknota26_CheckedChanged(object sender, EventArgs e)
        {
            MarcaCheckBox(Nota26, buttonExcluir26, checknota26);
        }

        private void checknota27_CheckedChanged(object sender, EventArgs e)
        {
            MarcaCheckBox(Nota27, buttonExcluir27, checknota27);
        }

        private void checknota28_CheckedChanged(object sender, EventArgs e)
        {
            MarcaCheckBox(Nota28, buttonExcluir28, checknota28);
        }

        private void checknota29_CheckedChanged(object sender, EventArgs e)
        {
            MarcaCheckBox(Nota29, buttonExcluir29, checknota29);
        }

        private void checknota30_CheckedChanged(object sender, EventArgs e)
        {
            MarcaCheckBox(Nota30, buttonExcluir30, checknota30);
        }

        private void checknota31_CheckedChanged(object sender, EventArgs e)
        {
            MarcaCheckBox(Nota31, buttonExcluir31, checknota31);
        }

        private void checknota32_CheckedChanged(object sender, EventArgs e)
        {
            MarcaCheckBox(Nota32, buttonExcluir32, checknota32);
        }

        private void checknota33_CheckedChanged(object sender, EventArgs e)
        {
            MarcaCheckBox(Nota33, buttonExcluir33, checknota33);
        }

        private void checknota34_CheckedChanged(object sender, EventArgs e)
        {
            MarcaCheckBox(Nota34, buttonExcluir34, checknota34);
        }
    }
}
